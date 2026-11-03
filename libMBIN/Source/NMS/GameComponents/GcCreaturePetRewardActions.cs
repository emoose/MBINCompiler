namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AC110A1EE89AADD, NameHash = 0xD40B99F)]
    public class GcCreaturePetRewardActions : NMSTemplate
    {
        // size: 0xA
        public enum PetActionEnum : uint {
            Tickle,
            Treat,
            Ride,
            Customise,
            Abandon,
            LayEgg,
            Adopt,
            Milk,
            HarvestSpecial,
            AddUnspentPetBattleLevel,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetActionEnum PetAction;
    }
}
