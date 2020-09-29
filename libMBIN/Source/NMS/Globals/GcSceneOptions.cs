using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2B0, GUID = 0xE631F099F9410CAB)]
    public class GcSceneOptions : NMSTemplate // doesn't seem like any of this is used by the game..
    {
        /* 0x000 */ public int RecentToolboxIndex;
        /* 0x004 */ public int SelectedToolboxIndex;
        /* 0x008 */ public bool OverrideBiome;
        [NMS(Size = 0x80)]
        /* 0x009 */ public string BiomeFile;
        /* 0x089 */ public bool OverrideWaterBiome;
        [NMS(Size = 0x80)]
        /* 0x08A */ public string WaterBiomeFile;
        /* 0x10A */ public bool OverrideCaveBiome;
        [NMS(Size = 0x80)]
        /* 0x10B */ public string CaveBiomeFile;
        /* 0x18B */ public bool OverrideTerrain;
        [NMS(Size = 0x80)]
        /* 0x18C */ public string TerrainFile;
        /* 0x20C */ public bool OverrideAtmosphere;
        [NMS(Size = 0x80)]
        /* 0x20D */ public string AtmosphereFile;
        [NMS(Size = 0x1)]
        /* 0x290 */ public Vector3f[] ForceResource;
        /* 0x2A0 */ public float ForceResourceSize;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2A4 */ public byte[] EndPadding;
    }
}
