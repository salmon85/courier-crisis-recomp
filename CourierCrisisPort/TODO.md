# Courier Crisis port — issue status

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [x] Main-menu selection forcing Start — fixed by the same BIOS C0 table fix
- [x] Pause menu — confirmed not broken; no pause-menu changes
- [x] In-level stopwatch frozen at ~2.70 s / never starts after restart
- [x] Results screen ("Congratulations!!" / "You're a loser, punk!!") delay
- [x] Draw-buffer deadlock during rapid menu transitions (`func_80012928`)

Notes:

- **Stopwatch / restart / results screen** — `RecompOne 9a23556`. The CD
  read-complete callback used to fire inside `CdRead`, before the caller had
  armed its per-frame refill (`GP+0x7C8`); the completion handler is what
  disarms it, so the game re-read the level header sector every ~150 frames
  and zeroed the leg table at `0x800EE6B8`. The callback is now delivered
  through the normal CD pump. Verified: the clock runs past 2.70 s, restarts
  from the pause menu, and level-failed results appear within a frame.
- **Draw-buffer deadlock** — `0x80012928` waits for a free buffer but the
  buffer is only recycled by `func_80075CEC`, which normally runs from the
  VBlank handler and requires a pending display flip to age two frames. The
  wait loop never returns to `VSync`, so the flip can never be acknowledged.
  `Patches.WaitDrawBuffer` (config patch in `config/Courier_Crisis.json`)
  pumps the display release while waiting. Verified with repeated rapid
  Z/S transitions.
- **Target arrow** — re-tested at standstill and while moving; the HUD arrow
  agrees with the compass/target marker in all runs after the CD fix.
  The original "wrong until the player moves" symptom did not reproduce.
  Needs a fresh report if it is still visible.
