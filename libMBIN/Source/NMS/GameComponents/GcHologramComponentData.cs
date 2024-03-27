using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x936AAB6252C334A9, NameHash = 0xF82082B5132B253)]
    public class GcHologramComponentData : NMSTemplate
    {
        /* 0x00 */ public bool UseStationLightColour;
        /* 0x10 */ public Colour HologramColour;
        /* 0x20 */ public bool DisableWhenNotInteracting;
        /* 0x24 */ public GcHologramState OnInteractState;
        /* 0x28 */ public GcHologramType HologramType;
        /* 0x2C */ public float AttractDistance;
        /* 0x30 */ public bool DisableOnInteract;
        /* 0x34 */ public float RotateTime;
        /* 0x38 */ public float MinSize;
        /* 0x3C */ public float MaxSize;
        /* 0x40 */ public GcHologramPivotType xPivot;
        /* 0x44 */ public GcHologramPivotType yPivot;
        /* 0x48 */ public GcHologramPivotType zPivot;
    }
}
