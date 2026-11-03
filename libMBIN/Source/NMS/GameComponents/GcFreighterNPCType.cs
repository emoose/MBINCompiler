namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77C97A1F24751F65, NameHash = 0x822165CA)]
    public class GcFreighterNPCType : NMSTemplate
    {
        // size: 0x5
        public enum FreighterNPCTypeEnum : uint {
            SquadronPilot,
            FrigateCaptain,
            WorkerBio,
            WorkerTech,
            WorkerIndustry,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FreighterNPCTypeEnum FreighterNPCType;
    }
}
