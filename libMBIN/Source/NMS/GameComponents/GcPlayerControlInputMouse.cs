using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x680E1192FFA80143, NameHash = 0x8CC79014E9CB899E)]
    public class GcPlayerControlInputMouse : NMSTemplate
    {
        /* 0x00 */ public GcCharacterControlInputValidity Validity;
        // size: 0x1
        public enum InputMouseModeEnum {
            ScreenCentrePos,
        }
        /* 0x04 */ public InputMouseModeEnum InputMouseMode;
        /* 0x08 */ public GcCharacterControlOutputSpace OutputSpace;
        /* 0x10 */ public NMSString0x10 Output;
        /* 0x20 */ public NMSString0x10 OutputLength;
    }
}
