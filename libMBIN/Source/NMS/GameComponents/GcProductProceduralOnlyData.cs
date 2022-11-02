using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x251F468009ABFA26, NameHash = 0xEACA21EDB93AD84A)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        /* 0x00 */ public int DropWeight;
        /* 0x04 */ public int BaseValueMin;
        /* 0x08 */ public int BaseValueMax;
        /* 0x0C */ public int AgeMin;
        /* 0x10 */ public int AgeMax;
        /* 0x18 */ public GcNameGeneratorWord Description;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public TkTextureResource HeroIcon;
    }
}
