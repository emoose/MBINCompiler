using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x994CED33741E97D, NameHash = 0xD929BD1550793EC2)]
    public class GcRagdollComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 Name;
        /* 0x48 */ public List<GcRagdollBone> RagdollBones;
        /* 0x58 */ public float JointTau;
        /* 0x5C */ public float JointDamping;
        /* 0x60 */ public float JointFriction;
        /* 0x64 */ public float ModelScaleAtCreation;
    }
}
