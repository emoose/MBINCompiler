using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPhotoModeSettings : NMSTemplate      // possibly in a global
    {
        /* 0x00 */ public float Fog;
        /* 0x04 */ public float CloudAmount;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public Vector4f SunDir;
        /* 0x20 */ public bool SunDirSet;
        /* 0x24 */ public float FoV;
        /* 0x28 */ public bool FoVSet;
        /* 0x2C */ public int DepthOfField;
        public string[] DepthOfFieldValues()
        {
            return new[] { "Off", "Automatic", "Manual" };
        }
        /* 0x30 */ public float DepthOfFieldAmount;
        /* 0x34 */ public float Vignette;
        /* 0x38 */ public int Filter;
    }
}
