using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8D71ACB4123A953, NameHash = 0x92F24A976CBF224B)]
    public class GcBaseBuildingPartStyleModel : NMSTemplate
    {
        /* 0x00 */ public GcBaseBuildingPartStyle Style;
        /* 0x04 */ public TkModelResource Model;
        /* 0x88 */ public TkModelResource Inactive;
    }
}
