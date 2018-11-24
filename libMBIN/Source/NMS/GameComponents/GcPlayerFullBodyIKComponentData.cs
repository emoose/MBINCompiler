using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F0, GUID = 0x8D3C85E56A8668D8)]
    public class GcPlayerFullBodyIKComponentData : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public bool EnableFootRaycasts;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x002 */ public byte[] Padding2;
        /* 0x008 */ public List<GcIkConstraint> HeadConstraints;
        /* 0x018 */ public List<GcIkConstraint> LegConstraints;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x028 */ public byte[] Padding28;
        /* 0x030 */ public GcIkConstraint COGConstraint;
        /* 0x180 */ public List<GcIkConstraint> RestrictConstraints;
        /* 0x190 */ public List<NMSString0x20> HandBones;

        public enum PlayerHeadUpAxisEnum { X, XNeg, Y, YNeg, Z, ZNeg }
		/* 0x1A0 */ public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1A4 */ public byte[] Padding1A4;
        /* 0x1A8 */ public List<GcCreatureIkData> JointDataDepreciated;
        /* 0x1B8 */ public bool UseFootGlue;
        /* 0x1BC */ public GcCharacterLookAtData LookAtSettings;
    }
}
