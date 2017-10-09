namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionSequenceCollectProduct : NMSTemplate      // size: 0x138
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcDefaultMissionProductEnum Default;
        /* 0x084 */ public gcproducttableEnum Product;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        /* 0x090 */ public bool WaitForSelected;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x091 */ public byte[] Padding91;
        [NMS(Size = 0x10)]
        /* 0x098 */ public string ForBuild;
        [NMS(Size = 0x10)]
        /* 0x0A0 */ public string ForRepair;
        [NMS(Size = 0x80)]
        /* 0x0B0 */ public string DebugText;
    }
}
