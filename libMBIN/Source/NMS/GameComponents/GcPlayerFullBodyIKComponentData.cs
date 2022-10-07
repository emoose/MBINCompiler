using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2868CB3FF7ADF800, NameHash = 0x80648B8FC1E7CB4D)]
    public class GcPlayerFullBodyIKComponentData : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public bool EnableFootRaycasts;
        /* 0x008 */ public List<GcIKConstraint> HeadConstraints;
        /* 0x018 */ public List<GcIKConstraint> LegConstraints;
        /* 0x030 */ public GcIKConstraint COGConstraint;
        /* 0x180 */ public List<GcIKConstraint> RestrictConstraints;
        /* 0x190 */ public List<NMSString0x20> HandBones;
        /* 0x1A0 */ public List<NMSString0x20> CameraNeckBones;
        /* 0x1B0 */ public GcIKConstraint SitConstraint;
        // size: 0x6
        public enum PlayerHeadUpAxisEnum {
            X,
            XNeg,
            Y,
            YNeg,
            Z,
            ZNeg
        }
        /* 0x300 */ public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        /* 0x308 */ public List<GcCreatureIkData> JointDataDeprecated;
        /* 0x318 */ public bool UseFootGlue;
        /* 0x31C */ public GcCharacterLookAtData LookAtSettings;
    }
}
