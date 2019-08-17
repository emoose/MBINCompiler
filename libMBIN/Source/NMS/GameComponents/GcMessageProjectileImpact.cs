using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6E628EFEA4C27F42, SubGUID = 0x7EBC25FE326CF24B)]
    public class GcMessageProjectileImpact: NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public int Damage;
        /* 0x14 */ public GcDamageType Type;
        /* 0x18 */ public bool Critical;
        /* 0x19 */ public bool Ineffective;
		public enum HitTypeEnum { Shootable, Terrain, Generic }
		public HitTypeEnum HitType;
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x20 */ public byte[] Padding20;     // ???
        /* 0x30 */ public Vector4f PosLocal;
        /* 0x40 */ public Vector4f PosOffset;
    }
}
