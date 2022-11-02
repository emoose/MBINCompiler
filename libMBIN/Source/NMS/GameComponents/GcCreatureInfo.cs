using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA102E2CBBC744CC, NameHash = 0xE85F02E30BDAB35D)]
    public class GcCreatureInfo : NMSTemplate
    {
        // size: 0x2
        public enum AgeEnum {
            Regular,
            Weird
        }
        /* 0x000 */ public AgeEnum Age;
        /* 0x004 */ public NMSString0x80 Gender1;
        /* 0x084 */ public NMSString0x80 Gender2;
        /* 0x104 */ public NMSString0x80 Temperament;
        /* 0x184 */ public NMSString0x80 Diet;
        /* 0x204 */ public NMSString0x80 Weight1;
        /* 0x284 */ public NMSString0x80 Height1;
        /* 0x304 */ public NMSString0x80 Weight2;
        /* 0x384 */ public NMSString0x80 Height2;
        /* 0x404 */ public float Weight1_float;
        /* 0x408 */ public float Height1_float;
        /* 0x40C */ public float Weight2_float;
        /* 0x410 */ public float Height2_float;
        /* 0x414 */ public NMSString0x80 Notes;
        /* 0x494 */ public GcRarity Rarity;
        /* 0x498 */ public NMSString0x20A BiomeDesc;
        /* 0x4B8 */ public NMSString0x20A TempermentDesc;
        /* 0x4D8 */ public NMSString0x20A DietDesc;
        /* 0x4F8 */ public NMSString0x20A NotesDesc;
    }
}
