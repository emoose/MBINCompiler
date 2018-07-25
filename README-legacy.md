# MBINCompiler [![Build status](https://ci.appveyor.com/api/projects/status/kivetlncubq7wktl?svg=true)](https://ci.appveyor.com/project/emoose/mbincompiler)

*Compiled builds can be downloaded from our AppVeyor page*: https://ci.appveyor.com/project/emoose/mbincompiler/build/artifacts

A tool for decompiling No Man's Sky MBIN files to eXML format, and recompiling them back from eXML to MBIN.

Bug reports are always welcomed!


### Requests & Issues

If you have any problems with the compiler feel free to write a bug report in the issue tracker.

Likewise, if you have any requests (eg. a request for a certain MBIN file to be supported) feel free to add your request to the issue tracker too.


### Contributions

Contributions would be a great help for this tool, there are hundreds of different templates in No Man's Sky and they sometimes change with new game updates. Mapping them all takes a lot of time, so help is appreciated.

If you'd like to contribute and have reverse-engineering experience, a short guide has been written for finding templates in the game EXE using IDA, [here](http://pastebin.com/5vdpCHnv).

Other ways you can contribute are:


If you want to talk about development feel free to join the NMS modding discord, MBINCompiler discussion usually takes place in the #mod-mbin channel: https://discordapp.com/invite/3Ytkxss (should work in browsers too, no client downloads needed)


### Examples

SCENES\SCREENSHOTS\E32015\MAINSETTINGS.MBIN:

```xml
<?xml version="1.0" encoding="utf-8"?>
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
  <Data name="PlayerState" template="GcPlayerSpawnStateData">
    <Data name="PlayerPositionInSystem" template="Vector4f">
      <Property name="x" value="0" />
      <Property name="y" value="0" />
      <Property name="z" value="0" />
      <Property name="t" value="0" />
    </Data>
    <Data name="PlayerTransformAt" template="Vector4f">
      <Property name="x" value="0" />
      <Property name="y" value="0" />
      <Property name="z" value="1" />
      <Property name="t" value="1" />
    </Data>
    <Data name="ShipPositionInSystem" template="Vector4f">
      <Property name="x" value="0" />
      <Property name="y" value="0" />
      <Property name="z" value="0" />
      <Property name="t" value="0" />
    </Data>
    <Data name="ShipTransformAt" template="Vector4f">
      <Property name="x" value="0" />
      <Property name="y" value="0" />
      <Property name="z" value="1" />
      <Property name="t" value="1" />
    </Data>
    <Property name="LastKnownPlayerState" value="OnStation" />
  </Data>
  <Property name="Events" />
  <Property name="PostWarpEvents" />
  <Property name="SpawnerOptionId" value="" />
</Data>
```
