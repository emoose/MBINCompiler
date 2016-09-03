# MBINCompiler [![Build status](https://ci.appveyor.com/api/projects/status/kivetlncubq7wktl?svg=true)](https://ci.appveyor.com/project/emoose/mbincompiler)

*Compiled builds can be downloaded from our AppVeyor page*: https://ci.appveyor.com/project/emoose/mbincompiler/build/artifacts

A tool for decompiling No Man's Sky MBIN files to XML format, and recompiling them back from XML to MBIN. MBIN reading seems to be working well, and so far we've managed to map every single main template used by the game (excluding globals templates).

MBIN compiling also seems to be working well in some cases, although it also seems to be having issues in others... Bug reports are always welcomed!

**Note that the format of XML files created by this tool could change at any time.**

If you use MBINCompiler to make a mod a mention of us would be appreciated, while not required it'd help a lot to get more exposure.

Also **please don't redistribute compiled exes outside of the AppVeyor page**, MBINC is changing very rapidly and having outdated builds hosted off-site would be detrimental.

**This also applies to any kind of GUI frontends or tool-sets which make use of MBINC!**

There are a lot of issues with MBINC at the moment, and as said above MBINC is changing very rapidly. Please wait until we have a stable release before including MBINC in any kind of GUI or tool-set. Although if you get in touch with me I might be in a good mood, feel free to find me on Discord!

If you want to link to us please link directly to this GitHub page. Once I've felt that MBINC has reached a decent level of usability it'll be released properly on all the usual mod sites, and you'll be free to use it as part of your programs.

Requests & Issues
---
If you have any problems with the compiler feel free to write a bug report in the issue tracker.

Likewise, if you have any requests (eg. a request for a certain MBIN file to be supported) feel free to add your request to the issue tracker too.

Contributions
---
Contributions would be a great help for this tool, there are hundreds of different templates in No Man's Sky and mapping them all out will take a *long* time, but with contributions from the modding community this effort can be sped up a great deal.

If you'd like to contribute and have reverse-engineering experience, I've written a guide for finding templates in the game EXE [here](http://pastebin.com/5vdpCHnv).

Templates aren't the only contributions accepted though, if you have any improvements to make to the source code they'd be greatly appreciated, while I like to pretend that I'm a decent C# programmer there are loads of people who have a better grasp of the language than I, if any of you can help to improve the code in any way I'd be very grateful.

If you want to talk about development feel free to join the NMS modding discord, MBINCompiler discussion usually takes place in the #mod-mbin channel: https://discordapp.com/invite/3Ytkxss (should work in browsers too, no client downloads needed)

Examples
---
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
