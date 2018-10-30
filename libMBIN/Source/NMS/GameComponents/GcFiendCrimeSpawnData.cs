using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C, GUID = 0x3044FA2248A22BAE)]
    public class GcFiendCrimeSpawnData : NMSTemplate
    {
		/* 0x00 */ public GcCreatureTypes Type;
        /* 0x04 */ public float MinDist;
        /* 0x08 */ public float MaxDist;
        [NMS(Size = 0x6)]
        /* 0x0C */ public int[] MinNum;
        [NMS(Size = 0x6)]
        /* 0x24 */ public int[] MaxNum;
    }
}
