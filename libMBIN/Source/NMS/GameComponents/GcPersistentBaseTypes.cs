using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDFD59E4AAF9945E7)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
		public enum PersistentBaseTypesEnum { HomePlanetBase, FreighterBase, ExternalPlanetBase, CivilianFreighterBase, FriendsPlanetBase, FriendsFreighterBase }
		public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
