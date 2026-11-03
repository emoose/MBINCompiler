namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC9D255E2BD00D7BE, NameHash = 0x650D128C)]
    public class TkIKPropagationLimitMode : NMSTemplate
    {
        // size: 0x4
        public enum IKPropagationLimitModeEnum : uint {
            RotationAndTranslation,
            TranslationOnly,
            RotationOnly,
            Block,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public IKPropagationLimitModeEnum IKPropagationLimitMode;
    }
}
