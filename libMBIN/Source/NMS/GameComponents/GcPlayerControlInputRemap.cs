using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xB5C81505F49BC3DB, NameHash = 0x907551D5CDAAAA41)]
    public class GcPlayerControlInputRemap : NMSTemplate
    {
        /* 0x0 */ public GcCharacterControlInputValidity Validity;
        /* 0x4 */ public GcInputActions Action;
        /* 0x8 */ public GcInputActions CanBeTriggeredBy;
        public enum InputRemapModeEnum { ReplaceOriginalBinding, AdditionalBinding }
        /* 0xC */ public InputRemapModeEnum InputRemapMode;
    }
}
