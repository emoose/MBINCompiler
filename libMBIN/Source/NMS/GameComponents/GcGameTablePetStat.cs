namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA387DC9D230163CD, NameHash = 0x25923C72)]
    public class GcGameTablePetStat : NMSTemplate
    {
        // size: 0x2
        public enum PetStatEnum : uint {
            Health,
            MaxHealth,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetStatEnum PetStat;
    }
}
