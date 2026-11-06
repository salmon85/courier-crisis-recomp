# Courier Crisis release TODO

- [x] Cross-platform launcher (`.bin`/`.cue`/`.chd` picker, EU music checkbox, Launch)
- [x] Raw `.bin` support via a generated single-track cue
- [x] USA disc validation (SLUS-00442, GAME.EXE at LBA 97)
- [x] Per-user data dir so the AppImage never writes inside its read-only mount
- [x] Windows self-contained zip
- [x] Linux self-contained AppImage
- [x] GitHub Actions: nightly release on `master`, tagged release on `v*`
- [x] Commit `CourierCrisisPort/generated/` so CI can build without the disc
- [x] Local build and USA/EU disc validation
- [ ] Tag `vX.Y.Z` when a version is ready to publish
