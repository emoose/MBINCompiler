using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x0C, GUID = 0x0C6BACB251FBD021)]
    public class GcBuildingSpawnSlot : NMSTemplate
    {
        public bool HasBuilding;
        public int BuildingDataIndex;
        public float Probability;
    }
}
