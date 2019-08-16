using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x2DFA382EE6F5DFC8, SubGUID = 0xB2C5F1A083F1473A)]
    public class GcNodeActivationAction : NMSTemplate
    {
		public enum NodeActiveStateEnum { Activate, Deactivate, Toggle, Add, Remove, RemoveChildren }
		public NodeActiveStateEnum NodeActiveState;

        [NMS(Size = 0x80)]
        /* 0x004 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string SceneToAdd;
        /* 0x104 */ public bool IncludePhysics;
        /* 0x105 */ public bool NotifyNPC;
        /* 0x106 */ public bool UseMasterModel;
        /* 0x107 */ public bool UseLocalNode;
        /* 0x108 */ public bool RestartEmitters;
        /* 0x109 */ public bool AffectModels;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x10A */ public byte[] EndPadding;
    }
}
