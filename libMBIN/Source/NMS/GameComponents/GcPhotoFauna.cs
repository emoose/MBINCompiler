using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B61AD4CDD5EE012, NameHash = 0xA9CCD3801AE3DA64)]
    public class GcPhotoFauna : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public GcPhotoCreature CreatureArea;
        /* 0xC */ public bool MustBePet;
    }
}
