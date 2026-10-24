# Courier Crisis port — remaining issues

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [x] Main-menu selection forcing Start — fixed by the same BIOS C0 table fix
- [x] Pause menu — confirmed not broken; all pause-menu diagnostics were removed
- [ ] Real levels fail immediately ("You're a loser, punk!! ... Failed")
- [ ] In-level stopwatch freezes / objective HUD disappears
- [ ] Target arrow points the wrong way until the player moves
- [ ] Results screen ("Congratulations!!") takes several seconds to appear
- [ ] Draw-buffer deadlock during rapid menu transitions (`func_80012928` waits forever)

Current lead for the gameplay bugs:

- A real career level (Civic Center Level 1) fails almost immediately.
- The level archive is `COURIER/CC/CC01.CAT` (LBA 3539, 1,310,720 bytes,
  640 sectors).
- The CD trace shows only a **1-sector read** at LBA 3539; the remaining
  ~1.31 MB of the level archive is never read through `CdRead`. Reads at
  LBA 3758 (8 sectors) and later are frontend files.
- The stopwatch, objective HUD, arrow and slow results screen are probably
  consequences of this level-load/mission-init failure, not independent bugs.

Status notes:

- Stopwatch formatter is correct: it takes frames at 60 fps and prints
  `MM:SS:hundredths`.
- Pause-menu behavior was never changed; only temporary tracing was added and
  removed.
