namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46761ED627F15DA7, NameHash = 0x3BAFC07)]
    public class GcRealityCommonFactions : NMSTemplate
    {
        // size: 0x6
        public enum AIFactionEnum : uint {
            Player,
            Civilian,
            Pirate,
            Police,
            Creature,
            Swarm,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AIFactionEnum AIFaction;
    }
}
