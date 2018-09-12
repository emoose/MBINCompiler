namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x53A2B5BA5E76D7E)]
    public class GcBuildingClusterPlacement : NMSTemplate
    {
		public enum BuildingClusterPlacementEnum { Cluster, Large, Small, None }
		public BuildingClusterPlacementEnum BuildingClusterPlacement;
    }
}
