using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA0E1569F241F7E28)]
    public class GcUniqueNPCSpawnData : NMSTemplate // 0x2C8 bytes
    {
		public enum NPCSpawnConditionEnum { Always, MiniStation }
		public NPCSpawnConditionEnum NPCSpawnCondition;

        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        [NMS(Size = 0x10)]
        /* 0x008 */ public string ID;
        /* 0x018 */ public GcResourceElement ResourceElement;

        /* 0x2C0 */ public GcAlienRace Race;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2C4 */ public byte[] EndPadding;

    }
}
