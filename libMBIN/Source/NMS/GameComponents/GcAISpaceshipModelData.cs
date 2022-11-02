using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x360D6ED1890514D7, NameHash = 0xA1AD260BA61A04EE)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Filename;
        /* 0x80 */ public GcSpaceshipClasses Class;
        /* 0x84 */ public GcAISpaceshipRoles AIRole;
        /* 0x88 */ public GcFrigateClass FrigateClass;
    }
}
