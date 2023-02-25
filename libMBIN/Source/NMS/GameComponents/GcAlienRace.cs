namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86B962D12194C137, NameHash = 0x9A5ABD2833971D0E)]
    public class GcAlienRace : NMSTemplate
    {
        // size: 0x8
        public enum AlienRaceEnum : uint {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None,
        }
        /* 0x0 */ public AlienRaceEnum AlienRace;
    }
}
