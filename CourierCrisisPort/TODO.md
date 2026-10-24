# Courier Crisis port — remaining issues

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [x] Main-menu selection forcing Start — fixed by the same BIOS C0 table fix
- [x] Pause menu — confirmed not broken; no pause-menu changes
- [x] In-level stopwatch frozen at ~2.70 s / never starts after restart

Status notes:

- Stopwatch: the CD read-complete callback used to fire inside `CdRead`,
  before the game had armed its per-frame refill (`GP+0x7C8`). The completion
  handler is what disarms that refill, so the game kept re-reading the level
  header sector every ~150 frames and zeroed the leg table at `0x800EE6B8`.
  Deferring the callback to the normal CD pump fixes the clock and the HUD.
  Commit `RecompOne 9a23556`.
- Stopwatch formatter is correct: frames at 60 fps -> `MM:SS:hundredths`.

Open:

- [ ] Target arrow points the wrong way until the player moves
- [ ] Results screen ("Congratulations!!") takes several seconds to appear
- [ ] Draw-buffer deadlock during rapid menu transitions (`func_80012928`)
