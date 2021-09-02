using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4B0, GUID = 0xBE828A0966C1B8BB, NameHash = 0x69B43206529CA591)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x000 */ public TkModelResource LegModel;
        /* 0x084 */ public TkModelResource GhostHeart;
        /* 0x108 */ public TkModelResource GhostHeartSelected;
        /* 0x18C */ public TkMaterialResource BuildEffectMaterial;
        /* 0x210 */ public TkModelResource RotateScaleGizmo;
        /* 0x294 */ public TkModelResource WiringFirefly;
        /* 0x318 */ public TkModelResource WiringSnapPoint;
        /* 0x39C */ public TkModelResource WiringSnapSelected;
        /* 0x420 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x430 */ public List<GcBaseBuildingGroup> Groups;
        /* 0x440 */ public List<GcBaseBuildingPalette> Palettes;
        /* 0x450 */ public List<GcId256List> PaletteGroups;
        /* 0x460 */ public List<GcBaseBuildingMaterial> Materials;
        /* 0x470 */ public List<GcId256List> MaterialGroups;
        /* 0x480 */ public GcBaseBuildingProperties Properties;
    }
}
