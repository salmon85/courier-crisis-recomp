# Courier Crisis port — remaining issues

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [x] Main-menu selection forcing Start — fixed by the same BIOS C0 table fix;
      the pause menu was not affected
- [ ] In-level stopwatch freezes at ~2.70 s (also in attract/demo races)
- [ ] Target arrow points the wrong way until the player moves; worse for distant targets
- [ ] Results screen ("Congratulations!!") takes several seconds to appear
- [ ] Draw-buffer deadlock during rapid menu transitions (`func_80012928` waits forever)

Status notes:

- Save crash / main menu: fixed by providing the BIOS C0 table (`0x674`) and a
  writable exception-handler stand-in (`0xC80`). Verified with
  `InitCARD`/`StopCARD`.
- Stopwatch: the formatter is correct (input is frames at 60 fps, output is
  `MM:SS:hundredths`); frame counter, VSync callbacks and buffer release keep
  running while the display freezes. Needs re-testing after the C0 fix.
- Arrow: uses the frontend/gameplay projection path (`func_80067E7C`,
  `catan`/`rcos`/`rsin`). Needs re-testing after the C0 fix.
- Pause-menu diagnostics were removed; no pause-menu behavior was changed.
