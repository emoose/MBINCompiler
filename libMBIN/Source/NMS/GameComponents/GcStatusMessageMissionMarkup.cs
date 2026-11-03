namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FC1D950607C1652, NameHash = 0x5F03B020)]
    public class GcStatusMessageMissionMarkup : NMSTemplate
    {
        // size: 0x13
        public enum MissionMarkupEnum : uint {
            KillFiend,
            KillPirate,
            KillSentinel,
            KillHazardousPlants,
            KillTraders,
            KillCreatures,
            KillPredators,
            KillDepot,
            KillWorms,
            KillSpookSquids,
            KillSwarm,
            FeedCreature,
            CollectBones,
            CollectScrap,
            Discover,
            CollectSubstanceProduct,
            Build,
            Always,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionMarkupEnum MissionMarkup;
    }
}
