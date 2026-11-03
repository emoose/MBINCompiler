namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BCE3A572C91A061, NameHash = 0xE1190DEF)]
    public class GcCharacterControlInputValidity : NMSTemplate
    {
        // size: 0x3
        public enum CharacterControlInputValidityEnum : uint {
            Always,
            PadOnly,
            KeyboardAnMouseOnly,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CharacterControlInputValidityEnum CharacterControlInputValidity;
    }
}
