# MBINCompiler [![Build status](https://ci.appveyor.com/api/projects/status/kivetlncubq7wktl?svg=true)](https://ci.appveyor.com/project/emoose/mbincompiler)

A tool for decompiling No Man's Sky .MBIN files to XML format, eventually it'll live to its name and actually compile XMLs back to MBIN too.

MBIN reading seems to be working well, structures just have to be created for all the different templates used by the game.

Note that the format of XML files created by this tool could change at any time.

Builds can be downloaded from our AppVeyor page: https://ci.appveyor.com/project/emoose/mbincompiler/build/artifacts

Requests & Issues
---
If you have any problems with the compiler feel free to write a bug report in the issue tracker.

Likewise, if you have any requests (eg. a request for a certain MBIN file to be supported) feel free to add your request to the issue tracker too.

Contributions
---
Contributions would be a great help for this tool, there are hundreds of different templates in No Man's Sky and mapping them all out will take a *long* time, but with contributions from the modding community this effort can be sped up a great deal.

If you'd like to contribute and have reverse-engineering experience, I've written a guide for finding templates in the game EXE [here](http://pastebin.com/5vdpCHnv).

Templates aren't the only contributions accepted though, if you have any improvements to make to the source code they'd be greatly appreciated, while I like to pretend that I'm a decent C# programmer there are loads of people who have a better grasp of the language than I, if any of you can help to improve the code in any way I'd be very grateful.

If you want to talk about development feel free to join the NMS modding discord, MBINCompiler discussion usually takes place in the #modding-mbin channel: https://discordapp.com/invite/3Ytkxss (should work in browsers too, no client downloads needed)

Examples
---
SCENES\SCREENSHOTS\E32015\MAINSETTINGS.MBIN:

```xml
<?xml version="1.0" encoding="utf-16"?>
<Data template="GcSceneSettings">
  <Property name="NextSettingFile" value="" />
  <Property name="SceneFile" value="SCENES/DEMOS/E32015/MAINSETTINGS/SCENES/SPACE.SCENE.MBIN" />
  <Property name="PlanetSceneFiles">
    <Data template="NMSString0x80">
      <Property name="Value" value="SCENES/DEMOS/E32015/MAINSETTINGS/SCENES/PLANET0.SCENE.MBIN" />
    </Data>
    <Data template="NMSString0x80">
      <Property name="Value" value="SCENES/DEMOS/E32015/MAINSETTINGS/SCENES/PLANET1.SCENE.MBIN" />
    </Data>
  </Property>
  <Property name="SolarSystemFile" value="SCENES/DEMOS/E32015/MAINSETTINGS/SOLARSYSTEMS/SOLARSYSTEM.MBIN" />
  <Property name="PlanetFiles1" value="SCENES/DEMOS/E32015/MAINSETTINGS/PLANETS/SUGAS.MBIN" />
  <Property name="PlanetFiles2" value="SCENES/DEMOS/E32015/MAINSETTINGS/PLANETS/OBEK.MBIN" />
  <Property name="PlanetFiles3" value="SCENES/DEMOS/E32015/MAINSETTINGS/PLANETS/ARMCHAIR.MBIN" />
  <Property name="PlanetFiles4" value="SCENES/DEMOS/E32015/MAINSETTINGS/PLANETS/METYUK.MBIN" />
  <Property name="PlanetFiles5" value="" />
  <Property name="ShipPreloadFiles" />
  <Property name="SpawnShip" value="False" />
  <Property name="SpawnInsideShip" value="False" />
  <Property name="Events" />
  <Property name="PostWarpEvents" />
  <Property name="SpawnerOptionId" value="" />
</Data>
```
