using System.Diagnostics;
using System.Numerics;
using CourierCrisis.Shared;
using ImGuiNET;
using NativeFileDialogNET;
using RecompOne.Runtime.Config;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.OpenGL.Extensions.ImGui;
using Silk.NET.Windowing;

namespace CourierCrisis.Launcher;

internal static class Program
{
    private static IWindow? _window;
    private static IInputContext? _input;
    private static GL? _gl;
    private static ImGuiController? _imgui;

    private static string _path = "";
    private static string _error = "";
    private static bool _eu;
    private static bool _launched;
    private static Process? _game;
    private static string[] _forwarded = [];

    public static int Main(string[] args)
    {
        AppPaths.EnsureDataDir();

        if (args.Contains("--check", StringComparer.OrdinalIgnoreCase))
            return Check(args);

        AppPaths.UseDataDirAsCurrent();
        Settings.EnsureLoaded();

        _path = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal))
                ?? Settings.Get("launcher.discPath", Settings.System.DiscPath)
                ?? "";
        _eu = args.Any(a => a.Equals("--EU", StringComparison.OrdinalIgnoreCase))
              || Settings.Get("launcher.euMusic", false);
        _forwarded = args
            .Where(a => a.StartsWith("--", StringComparison.Ordinal) &&
                        !a.Equals("--EU", StringComparison.OrdinalIgnoreCase))
            .ToArray();

        if (_path.Length > 0)
            _error = DiscValidation.Validate(_path) ?? "";

        return RunWindow();
    }

    private static int Check(string[] args)
    {
        var path = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal));
        if (path == null)
        {
            Console.Error.WriteLine("usage: CourierCrisisLauncher --check <disc.bin|disc.cue|disc.chd>");
            return 2;
        }

        var problem = DiscValidation.Validate(path);
        if (problem != null)
        {
            Console.Error.WriteLine(problem);
            return 1;
        }

        Console.WriteLine("OK: " + DiscSource.Resolve(path));
        return 0;
    }

    private static int RunWindow()
    {
        foreach (var api in ApiChain())
        {
            try
            {
                _window = Window.Create(WindowOptions.Default with
                {
                    Size = new Vector2D<int>(620, 300),
                    Title = "Courier Crisis",
                    VSync = true,
                    UpdatesPerSecond = 0,
                    FramesPerSecond = 0,
                    API = api
                });

                _window.Load += OnLoad;
                _window.Render += OnRender;
                _window.Closing += OnClosing;
                _window.Initialize();

                while (!_window.IsClosing)
                {
                    _window.DoEvents();
                    _window.DoRender();
                }

                return 0;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"[Launcher] OpenGL {api.Version} unavailable: {e.Message}");
                _window = null;
            }
        }

        Console.Error.WriteLine("[Launcher] no usable OpenGL context was found");
        return 1;
    }

    private static GraphicsAPI[] ApiChain()
    {
        if (OperatingSystem.IsMacOS())
            return
            [
                new GraphicsAPI(ContextAPI.OpenGL, ContextProfile.Core, ContextFlags.ForwardCompatible,
                    new APIVersion(4, 1))
            ];

        return
        [
            new GraphicsAPI(ContextAPI.OpenGL, ContextProfile.Core, ContextFlags.Default, new APIVersion(3, 3)),
            new GraphicsAPI(ContextAPI.OpenGL, ContextProfile.Compatability, ContextFlags.Default, new APIVersion(2, 1))
        ];
    }

    private static void OnLoad()
    {
        _input = _window!.CreateInput();
        _gl = GL.GetApi(_window);
        _imgui = new ImGuiController(_gl, _window, _input, null, ConfigureImGui);
    }

    private static void ConfigureImGui()
    {
        ImGui.StyleColorsDark();

        var io = ImGui.GetIO();
        io.ConfigFlags |= ImGuiConfigFlags.NavEnableKeyboard;
        unsafe
        {
            io.NativePtr->IniFilename = null;
        }

        var scale = QueryScale();
        if (scale > 1.05f)
        {
            io.FontGlobalScale = scale;
            ImGui.GetStyle().ScaleAllSizes(scale);
        }
    }

    private static unsafe float QueryScale()
    {
        try
        {
            var glfw = Silk.NET.GLFW.Glfw.GetApi();
            var monitor = glfw.GetPrimaryMonitor();
            if (monitor == null) return 1f;
            glfw.GetMonitorContentScale(monitor, out var xs, out var ys);
            var scale = MathF.Max(xs, ys);
            return scale is >= 0.5f and <= 8f ? scale : 1f;
        }
        catch
        {
            return 1f;
        }
    }

    private static void OnRender(double dt)
    {
        if (_launched)
        {
            if (_game is null || _game.HasExited)
                _window!.Close();
            return;
        }

        _imgui!.Update((float)dt);

        _gl!.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
        var size = _window!.FramebufferSize;
        _gl.Viewport(0, 0, (uint)size.X, (uint)size.Y);
        _gl.ClearColor(0.07f, 0.07f, 0.08f, 1f);
        _gl.Clear(ClearBufferMask.ColorBufferBit);

        DrawUi();
        _imgui.Render();
    }

    private static void DrawUi()
    {
        var viewport = ImGui.GetMainViewport();
        ImGui.SetNextWindowPos(viewport.WorkPos);
        ImGui.SetNextWindowSize(viewport.WorkSize);
        ImGui.Begin("##launcher",
            ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoSavedSettings |
            ImGuiWindowFlags.NoBringToFrontOnFocus);

        ImGui.Spacing();
        ImGui.TextWrapped("Select your Courier Crisis (USA) disc image. Raw .bin, .cue and .chd are supported.");
        ImGui.TextDisabled("USA disc only: SLUS-00442.");
        ImGui.Spacing();

        ImGui.SetNextItemWidth(ImGui.GetContentRegionAvail().X - 110f);
        ImGui.InputText("##disc", ref _path, 4096);
        ImGui.SameLine();
        if (ImGui.Button("Browse...", new Vector2(100f, 0f)))
            Browse();

        ImGui.Spacing();
        ImGui.Checkbox("Use European music selection", ref _eu);

        if (_error.Length > 0)
        {
            ImGui.Spacing();
            ImGui.PushStyleColor(ImGuiCol.Text, new Vector4(1f, 0.38f, 0.38f, 1f));
            ImGui.TextWrapped(_error);
            ImGui.PopStyleColor();
        }

        ImGui.Spacing();
        ImGui.Separator();
        ImGui.Spacing();

        if (ImGui.Button("Launch", new Vector2(140f, 0f)))
            Launch();

        ImGui.End();
    }

    private static void Browse()
    {
        try
        {
            string? directory = null;
            if (_path.Length > 0 && File.Exists(_path))
                directory = Path.GetDirectoryName(Path.GetFullPath(_path));

            using var dialog = new NativeFileDialog().SelectFile().AddFilter("Disc image", "bin,cue,chd");
            if (dialog.Open(out string? picked, directory) == DialogResult.Okay &&
                !string.IsNullOrWhiteSpace(picked))
            {
                _path = picked;
                _error = DiscValidation.Validate(_path) ?? "";
            }
        }
        catch (Exception e)
        {
            _error = "Failed to open the file picker: " + e.Message;
        }
    }

    private static void Launch()
    {
        var problem = DiscValidation.Validate(_path);
        if (problem != null)
        {
            _error = problem;
            return;
        }

        string cue;
        try
        {
            cue = DiscSource.Resolve(_path);
        }
        catch (Exception e)
        {
            _error = e.Message;
            return;
        }

        var game = Path.Combine(AppContext.BaseDirectory,
            OperatingSystem.IsWindows() ? "CourierCrisis.exe" : "CourierCrisis");
        if (!File.Exists(game))
        {
            _error = "Game executable not found next to the launcher: " + game;
            return;
        }

        try
        {
            Settings.System.DiscPath = cue;
            Settings.Set("launcher.discPath", _path);
            Settings.Set("launcher.euMusic", _eu);
            Settings.Save();

            var start = new ProcessStartInfo(game)
            {
                UseShellExecute = false,
                WorkingDirectory = AppContext.BaseDirectory,
                CreateNoWindow = true
            };
            start.ArgumentList.Add(cue);
            if (_eu) start.ArgumentList.Add("--EU");
            foreach (var flag in _forwarded) start.ArgumentList.Add(flag);

            _game = Process.Start(start);
            if (_game == null)
            {
                _error = "The game process could not be started.";
                return;
            }

            _launched = true;
            _window!.IsVisible = false;
        }
        catch (Exception e)
        {
            _error = "Failed to launch the game: " + e.Message;
        }
    }

    private static void OnClosing()
    {
        _imgui?.Dispose();
        _gl?.Dispose();
    }
}
