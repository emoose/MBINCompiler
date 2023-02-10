using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C9C7C36F20CBADD, NameHash = 0x1250AC356CE3B7B)]
    public class GcBaseBuildingSettingsAction : NMSTemplate
    {
        // size: 0x3
        public enum UseCorePartsOnlyEnum {
            False,
            True,
            DontCare,
        }
        /* 0x0 */ public UseCorePartsOnlyEnum UseCorePartsOnly;
        /* 0x4 */ public TkGraphicsDetailTypes MaxAffectedDetail;
    }
}
