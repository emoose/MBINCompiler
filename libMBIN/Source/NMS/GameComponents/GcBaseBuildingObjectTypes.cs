namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9C2FA5C781B3CA2E)]
    public class GcBaseBuildingObjectTypes : NMSTemplate
    {
		public enum BaseBuildingObjectTypeEnum { Building, BuildingFoundation, BuildingDecoration, Decoration, Foundation }
		public BaseBuildingObjectTypeEnum BaseBuildingObjectType;
    }
}
