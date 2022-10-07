namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A2D297CF203200D, NameHash = 0xCCEE5C02303ACEC6)]
    public class GcPlayerCharacterStateData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Locomotion0H;
        /* 0x10 */ public NMSString0x10 Locomotion1H;
        /* 0x20 */ public NMSString0x10 Locomotion2H;
        /* 0x30 */ public NMSString0x10 AimTree1HPitch;
        /* 0x40 */ public NMSString0x10 AimTree1HYaw;
        /* 0x50 */ public NMSString0x10 AimTree2HPitch;
        /* 0x60 */ public NMSString0x10 AimTree2HYaw;
        /* 0x70 */ public NMSString0x10 HitReact0H;
        /* 0x80 */ public NMSString0x10 HitReact1H;
        /* 0x90 */ public NMSString0x10 HitReact2H;
        /* 0xA0 */ public bool KeepHeadForward;
    }
}
