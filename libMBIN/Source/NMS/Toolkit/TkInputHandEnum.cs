using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4, GUID = 0xA63EFCA0252EEBBD, NameHash = 0xC47947D0C35F984E)]
    public class TkInputHandEnum : NMSTemplate
    {
        public enum InputHandEnum { None, Left, Right }
        public InputHandEnum InputHand;
    }
}