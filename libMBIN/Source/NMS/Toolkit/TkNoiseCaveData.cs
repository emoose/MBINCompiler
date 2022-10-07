using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5C0A92328BBE7F0F, NameHash = 0xE2442EEFEFEF9518)]
    public class TkNoiseCaveData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseFeatureData Mouth;
        /* 0x44 */ public TkNoiseFeatureData Tunnel;
    }
}
