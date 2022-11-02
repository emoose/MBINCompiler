using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4EA77AA25B6EEF0, NameHash = 0x799BCCB536A8AD49)]
    public class GcPhotoBuildings : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public GcPhotoBuilding BuildingType;
    }
}
