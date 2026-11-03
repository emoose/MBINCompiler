using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E3F91E04244F8FF, NameHash = 0x94D3825D)]
    public class GcPetBattlerEffectTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x0 */ public GcPetBattlerEffectData[] EffectData;
    }
}
