using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3D746125E36E59C, NameHash = 0x1A07394B)]
    public class TkProceduralInstance : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10)]
        /* 0x0 */ public TkProceduralInstanceData[] Data;
    }
}
