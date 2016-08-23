using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcSceneSettings : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x000 */ public string NextSettingFile;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x080 */ public string SceneFile;

        /* 0x100 */ public List<NMSString0x80> PlanetSceneFiles;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x110 */ public string SolarSystemFile;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x190 */ public string PlanetFiles1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x210 */ public string PlanetFiles2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x290 */ public string PlanetFiles3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x310 */ public string PlanetFiles4;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x390 */ public string PlanetFiles5;

        /* 0x410 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x420 */ public bool SpawnShip;
        /* 0x421 */ public bool SpawnInsideShip;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xE)]
        [NMSAttribute(Ignore = true)]
        /* 0x422 */ public byte[] Padding422;

        /* 0x430 */ public GcPlayerSpawnStateData PlayerState;

        /* 0x480 */ public List<NMSTemplate> Events;
        /* 0x490 */ public List<NMSTemplate> PostWarpEvents;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x4A0 */ public string SpawnerOptionId;
    }
}
