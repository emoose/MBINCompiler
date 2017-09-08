namespace libMBIN.Models.Structs
{
    public class GcZoomData : NMSTemplate       // in gameplayglobals?
    {
        public int ZoomType;
        public string[] ZoomTypeValues()
        {
            return new[] { "None", "Far", "Mid", "Close" };
        }

        /* 0x04 */ public float EffectStrength;     // 3F800000h
        /* 0x08 */ public float MoveSpeed;          // 41200000h
        /* 0x0C */ public float FoV;                // 41200000h
        /* 0x10 */ public float MinScanDistance;
        /* 0x14 */ public float MaxScanDistance;    // 41200000h
        /* 0x18 */ public float WalkSpeed;          // 3F800000h
    }
}
