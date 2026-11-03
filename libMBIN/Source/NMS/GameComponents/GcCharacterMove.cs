namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77054C30BC8FC9B9, NameHash = 0x40E7868E)]
    public class GcCharacterMove : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Input;
        // size: 0x2
        public enum ModeEnum : uint {
            SetVelocity,
            ApplyForce,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public ModeEnum Mode;
        [NMS(Index = 1)]
        /* 0x14 */ public float Strength;
    }
}
