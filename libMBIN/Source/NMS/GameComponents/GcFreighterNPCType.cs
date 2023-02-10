namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A4F46CA881F933, NameHash = 0xC53DA60AB5E3B8A5)]
    public class GcFreighterNPCType : NMSTemplate
    {
        // size: 0x5
        public enum FreighterNPCTypeEnum {
            SquadronPilot,
            FrigateCaptain,
            WorkerBio,
            WorkerTech,
            WorkerIndustry,
        }
        /* 0x0 */ public FreighterNPCTypeEnum FreighterNPCType;
    }
}
