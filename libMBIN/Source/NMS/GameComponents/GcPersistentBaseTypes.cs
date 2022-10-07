namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF61D776A97B552A, NameHash = 0x1E20A14918514C43)]
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
