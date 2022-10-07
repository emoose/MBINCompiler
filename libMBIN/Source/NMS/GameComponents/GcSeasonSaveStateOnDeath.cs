namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x767B76ECCDE3A3B0, NameHash = 0x800386833E2445B5)]
    public class GcSeasonSaveStateOnDeath : NMSTemplate
    {
        // size: 0x4
        public enum SeasonSaveStateOnDeathEnum {
            Standard,
            ResetAndQuit,
            ResetPosSaveAndQuit,
            SaveAndQuit
        }
        /* 0x0 */ public SeasonSaveStateOnDeathEnum SeasonSaveStateOnDeath;
    }
}
