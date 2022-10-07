using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x324E5B346B2F2882, NameHash = 0x2D2DE27512E8C450)]
    public class GcPhotoFlora : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public GcPhotoPlant PlantType;
    }
}
