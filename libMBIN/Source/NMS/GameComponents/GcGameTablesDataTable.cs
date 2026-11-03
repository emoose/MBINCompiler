using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35A7B2DBC5BBA98, NameHash = 0x618AA3CD)]
    public class GcGameTablesDataTable : NMSTemplate
    {
        [NMS(Index = 3, KeyField = "Id")]
        /* 0x00 */ public HashMap<GcGameTableAIPlayerConfig> AIPlayerConfigs;
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x30 */ public HashMap<GcGameTableConfig> GameTableConfigs;
        [NMS(Index = 2, KeyField = "Id")]
        /* 0x60 */ public HashMap<GcGameTableGameConfig> GameTableGameConfig;
        [NMS(Index = 1, KeyField = "Id")]
        /* 0x90 */ public HashMap<GcGameTableSpawnData> GameTableSpawnData;
    }
}
