using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC26D00872561C860, NameHash = 0x907551D5CDAAAA41)]
    public class GcPlayerControlInputRemap : NMSTemplate
    {
        /* 0x0 */ public GcCharacterControlInputValidity Validity;
        /* 0x4 */ public GcInputActions Action;
        /* 0x8 */ public GcInputActions CanBeTriggeredBy;
        // size: 0x2
        public enum InputRemapModeEnum : uint {
            ReplaceOriginalBinding,
            AdditionalBinding,
        }
        /* 0xC */ public InputRemapModeEnum InputRemapMode;
    }
}
