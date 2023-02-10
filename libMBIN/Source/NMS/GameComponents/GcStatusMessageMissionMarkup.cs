namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57E24DA1D74D7359, NameHash = 0x8E8EC2C807363E97)]
    public class GcStatusMessageMissionMarkup : NMSTemplate
    {
        // size: 0x11
        public enum MissionMarkupEnum {
            KillFiend,
            KillPirate,
            KillSentinel,
            KillHazardousPlants,
            KillTraders,
            KillCreatures,
            KillPredators,
            KillDepot,
            KillWorms,
            FeedCreature,
            CollectBones,
            CollectScrap,
            Discover,
            CollectSubstanceProduct,
            Build,
            Always,
            None,
        }
        /* 0x0 */ public MissionMarkupEnum MissionMarkup;
    }
}
