using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7EB1568C64FBE4CA, NameHash = 0x3FFAD7C8)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x6, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        /* 0x00 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x60 */ public HashMap<GcAISpaceshipModelData> ShipModels;
    }
}
