namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEF45E7C90B2A83C, NameHash = 0x800386833E2445B5)]
    public class GcSeasonSaveStateOnDeath : NMSTemplate
    {
        // size: 0x4
        public enum SeasonSaveStateOnDeathEnum : uint {
            Standard,
            ResetAndQuit,
            ResetPosSaveAndQuit,
            SaveAndQuit,
        }
        /* 0x0 */ public SeasonSaveStateOnDeathEnum SeasonSaveStateOnDeath;
    }
}
