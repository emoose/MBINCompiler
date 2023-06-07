using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x954A7CAAD6ABB15A, NameHash = 0x828E03CA6A18781E)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public float WaitTime;
        /* 0x84 */ public bool BlockTimedScans;
        [NMS(Size = 0xB, EnumType = typeof(GcScanType.ScanTypeEnum))]
        /* 0x85 */ public bool[] ScanTypesToOverride;
        /* 0x90 */ public NMSString0x10 ScanOverrideData;
        /* 0xA0 */ public bool RequiresMissionActive;
        /* 0xA1 */ public NMSString0x80 DebugText;
    }
}
