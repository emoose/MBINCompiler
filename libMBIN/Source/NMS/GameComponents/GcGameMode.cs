namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE654997778945D49, NameHash = 0x4AAFAF35)]
    public class GcGameMode : NMSTemplate
    {
        // size: 0x7
        public enum PresetGameModeEnum : uint {
            Unspecified,
            Normal,
            Creative,
            Survival,
            Ambient,
            Permadeath,
            Seasonal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PresetGameModeEnum PresetGameMode;
    }
}
