using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x44, GUID = 0x7E08D2891797A237, NameHash = 0x9F76738BACABEAD2)]
    public class GcFiendCrimeSpawnData : NMSTemplate
    {
		/* 0x00 */ public GcCreatureTypes Type;
        /* 0x04 */ public float MinDist;
        /* 0x08 */ public float MaxDist;
        // Possible have GcGameMode as the enum
        [NMS(Size = 0x7)]
        /* 0x0C */ public int[] MinNum;
        [NMS(Size = 0x7)]
        /* 0x28 */ public int[] MaxNum;
    }
}
