# MBINCompiler

A tool for decompiling No Man's Sky .MBIN files to XML format, eventually it'll live to its name and actually compile XMLs back to MBIN too.

MBIN reading seems to be working well, structures just have to be created for all the different templates used by the game.

Note that the format of XML files created by this tool could change at any time.

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
