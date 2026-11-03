namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x435D77447ACE4DA9, NameHash = 0xBDDBAEB8)]
    public class TkNavMeshAgentFamily : NMSTemplate
    {
        // size: 0x5
        public enum NavMeshAgentFamilyEnum : byte {
            Small,
            Medium,
            Large,
            VeryLarge,
            WorldBoss,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAgentFamilyEnum NavMeshAgentFamily;
    }
}
