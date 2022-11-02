namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x495908940DC5C069, NameHash = 0x3375DA42DA55F3B3)]
    public class GcPlayerStickData : NMSTemplate
    {
        /* 0x00 */ public float AcceleratorStickPoint;
        /* 0x04 */ public float AcceleratorMinTime;
        /* 0x08 */ public float Accelerate;
        /* 0x0C */ public float AccelerateAngle;
        /* 0x10 */ public float Turn;
        /* 0x14 */ public float TurnFast;
        /* 0x18 */ public float StickyFactor;
    }
}
