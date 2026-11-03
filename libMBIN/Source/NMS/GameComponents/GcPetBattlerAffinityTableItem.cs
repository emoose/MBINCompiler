using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66B605C003CA0325, NameHash = 0x1599A374)]
    public class GcPetBattlerAffinityTableItem : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x0 */ public float[] TargetPetAffinity;
    }
}
