namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8, GUID = 0x0DF5541EE134C5839)]
    public class GcPhotoBuildings : NMSTemplate
    {
        public short AmountMin;
        public short AmountMax;
        public GcPhotoBuilding BuildingType;
    }
}
