namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAA4DBFE9DCC9844, NameHash = 0xA57475D6E3E6E9A5)]
    public class GcRealityCommonFactions : NMSTemplate
    {
        // size: 0x5
        public enum AIFactionEnum {
            Player,
            Civilian,
            Pirate,
            Police,
            Creature
        }
        /* 0x0 */ public AIFactionEnum AIFaction;
    }
}
