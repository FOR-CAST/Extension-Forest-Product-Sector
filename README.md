# Forest_Product_Sector_Module
Code for building a custom model for tracking carbon transfers and emissions from wood products. IPCC default and USFS model structures are provided in examples.

Link to installer

https://github.com/LANDIS-II-Foundation/Extension-Forest-Product-Sector/tree/main/deploy/installer

## Building from source

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download). Builds on
Linux, macOS and Windows.

```
pwsh -File lib/support_libs_download.ps1 -WorkingDirectory lib   # or: cd lib && ./support_libs_download.ps1
dotnet build FPS.csproj -c Release
```

The build output is `bin/Release/net8.0/Landis.Extension.FPS-v1.dll`.

Dependencies come from two places, and both are public:

- **LANDIS-II Core libraries** (`Landis.Core` and friends) restore from the
  LANDIS-II Foundation MyGet feed declared in `NuGet.config`. They are *not*
  on nuget.org, so a build without that file fails to restore.
- **LANDIS-II support libraries** (`Landis.Library.Metadata-v2`,
  `Landis.Library.Parameters-v2`, `MathNet.Numerics`) are downloaded into
  `lib/` by `lib/support_libs_download.ps1` from
  [Support-Library-Dlls-v8](https://github.com/LANDIS-II-Foundation/Support-Library-Dlls-v8).
  They are gitignored, so this step is required on a fresh clone.

Neither step needs an existing LANDIS-II installation.

