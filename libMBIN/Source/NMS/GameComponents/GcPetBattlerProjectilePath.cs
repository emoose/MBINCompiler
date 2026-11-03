namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D04FCD1CF8E5F5B, NameHash = 0x90473F2D)]
    public class GcPetBattlerProjectilePath : NMSTemplate
    {
        // size: 0x3
        public enum PetBattlerProjectilePathEnum : uint {
            Line,
            Arc,
            Instant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerProjectilePathEnum PetBattlerProjectilePath;
    }
}
