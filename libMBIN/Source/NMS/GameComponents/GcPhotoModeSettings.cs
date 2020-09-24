using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xBF6A9C1A7F3A786, NameHash = 0xE5075EC0403F94CA)]
    public class GcPhotoModeSettings : NMSTemplate
    {
        /* 0x00 */ public float Fog;
        /* 0x04 */ public float CloudAmount;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public Vector4f SunDir;
        /* 0x20 */ public bool SunDirSet;
        /* 0x24 */ public float FoV;
        /* 0x28 */ public bool FoVSet;
		public enum DepthOfFieldEnum { Off, Automatic, Manual }
		/* 0x2C */ public DepthOfFieldEnum DepthOfField;
        /* 0x30 */ public int DepthOfFieldStrengthSetting;
        /* 0x34 */ public float DepthOfFieldDistance;
        /* 0x38 */ public float DepthOfFieldDistanceSpace;
        /* 0x3C */ public float HalfFocalPlaneDepth;
        /* 0x40 */ public float HalfFocalPlaneDepthSpace;
        /* 0x44 */ public float Vignette;
        /* 0x48 */ public int Filter;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] EndPadding;
    }
}
