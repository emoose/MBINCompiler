using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x18, GUID = 0x376A8AFDA5EF60B4)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        public List<NMSString0x80> ReplicaComponentMask;
		public enum ReplicationRangeEnum { Universal, System, Planet, Space, PlanetLocal }
		public ReplicationRangeEnum ReplicationRange;
		public enum SpawnTypeEnum { Basic, Creature }
		public SpawnTypeEnum SpawnType;
    }
}
