namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F1B04FF9DA16880, NameHash = 0x1E20A14918514C43)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
        // size: 0x9
        public enum PersistentBaseTypesEnum {
            HomePlanetBase,
            FreighterBase,
            ExternalPlanetBase,
            CivilianFreighterBase,
            FriendsPlanetBase,
            FriendsFreighterBase,
            SpaceBase,
            GeneratedPlanetBase,
            GeneratedPlanetBaseEdits
        }
        /* 0x0 */ public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
