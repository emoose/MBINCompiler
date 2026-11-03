namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52DD9FA5C913564, NameHash = 0x47646960)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0xB
        public enum FrigateClassEnum : uint {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon,
            Pirate,
            GhostShip,
            Swarm,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateClassEnum FrigateClass;
    }
}
