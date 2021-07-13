# OhShape - Disable Good Walls
A mod for OhShape that disables the 'good wall' visual effect that is shown when you successfully passed a wall.

## Download
Get the latest release from the [Project Releases](https://github.com/Shadnix-was-taken/OhShape-DisableGoodWalls/releases) page.

## Installation
This mod requires MelonLoader 0.4.0 or newer in order work. You can find installation instructions and more information at:

- [MelonLoader Wiki](https://melonwiki.xyz/)
- [MelonLoader Github Repository](https://github.com/HerpDerpinstine/MelonLoader)

In order to install and use this mod:

1. Install MelonLoader (point it to your `OhShape.exe` file)
2. Start and quit OhShape once
3. Move the DLL file of this mod to your `OhShape\Mods\` directory.

## Removal
Delete the DLL file of this mod from you `OhShape\Mods\` directory.

## Developers

### Contributing to Simple Song Info
In order to build this project, you'll need to have OhShape and MelonLoader installed. In addition, please add a `DisableGoodWalls.csproj.user` file in the project directory and specify where your game is located on your disk:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <!-- Change this path if necessary. Make sure it doesn't end with a backslash. -->
    <GameDirPath>C:\Program Files\Steam\steamapps\common\OhShape</GameDirPath>
  </PropertyGroup>
</Project>
```
