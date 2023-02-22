namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB81DE26A5931326, NameHash = 0x17FDBAA75DF0569B)]
    public class GcCharacterControlOutputSpace : NMSTemplate
    {
        // size: 0x3
        public enum CharacterControlOutputSpaceEnum {
            CameraRelative,
            CameraRelativeTopDown,
            Raw,
        }
        /* 0x0 */ public CharacterControlOutputSpaceEnum CharacterControlOutputSpace;
    }
}
