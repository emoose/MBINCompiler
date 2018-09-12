using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x62ECC2A88402F1DD)]
    public class GcExternalObjectListOptions : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
		[NMS(Size = 0x10)]
		/* 0x10 */ public string ResourceHint;
        /* 0x20 */ public float Probability;
        /* 0x24 */ public GcTerrainTileType TileType;
        /* 0x28 */ public bool AllowLimiting;
        /* 0x29 */ public bool ChooseUsingLifeLevel;
        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding;
        /* 0x30 */ public List<NMSString0x80> Options;
    }
}
