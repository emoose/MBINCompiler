using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x7F19CAEEA79ADD39, NameHash = 0xB2C5F1A083F1473A)]
    public class GcNodeActivationAction : NMSTemplate
    {
		public enum NodeActiveStateEnum { Activate, Deactivate, Toggle, Add, Remove, RemoveChildren }
		public NodeActiveStateEnum NodeActiveState;

        [NMS(Size = 0x80)]
        /* 0x004 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string SceneToAdd;
        /* 0x104 */ public bool IncludePhysics;
        /* 0x105 */ public bool IncludeChildPhysics;
        /* 0x106 */ public bool NotifyNPC;
        /* 0x107 */ public bool UseMasterModel;
        /* 0x108 */ public bool UseLocalNode;
        /* 0x109 */ public bool RestartEmitters;
        /* 0x10A */ public bool AffectModels;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x10B */ public byte[] EndPadding;
    }
}
