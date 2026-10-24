# Courier Crisis port — remaining issues

- [x] Memory-card save crash (`_ExitCard` / missing BIOS C0 table)
- [ ] Main-menu selection: choosing anything other than Start forces Start
- [ ] In-level stopwatch freezes at ~2.70 s (also in attract/demo races)
- [ ] Target arrow points the wrong way until the player moves; worse for distant targets
- [ ] Results screen ("Congratulations!!") takes several seconds to appear
- [ ] Draw-buffer deadlock during rapid menu transitions (`func_80012928` waits forever)

Status notes:

- Save crash: fixed by providing the BIOS C0 table (`0x674`) and a writable
  exception-handler stand-in (`0xC80`). Verified with `InitCARD`/`StopCARD`.
- Menu: the state dispatch table and pad button mapping are intact. The bug is
  in the frontend carousel/selection logic.
- Stopwatch: frame counter, VSync callbacks and buffer release keep running
  while the display freezes; 64-bit division was verified correct.
- Arrow: uses the frontend/gameplay projection path (`func_80067E7C`,
  `catan`/`rcos`/`rsin`).
