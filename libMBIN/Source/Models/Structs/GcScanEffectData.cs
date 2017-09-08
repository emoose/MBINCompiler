namespace libMBIN.Models.Structs
{
    public class GcScanEffectData : NMSTemplate        // size: 0x50         // in gameplay globals?
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
		/* 0x10 */ public int ScanEffectType;
		public string[] ScanEffectTypeValues()
		{
			return new[] { "Building", "TargetShip", "Creature", "Ground", "Objects" };
		}
		[NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

		/* 0x20 */ public Colour Colour;
		/* 0x30 */ public float BasecolourIntensity;
		/* 0x34 */ public float ScanlinesSeparation;
		/* 0x38 */ public float FresnelIntensity;
		/* 0x3C */ public bool FixedUpAxis;
		/* 0x3D */ public bool Transparent;
		/* 0x40 */ public float FadeInTime;
		/* 0x44 */ public float FadeOutTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x48 */ public byte[] EndPadding;
    }
}
