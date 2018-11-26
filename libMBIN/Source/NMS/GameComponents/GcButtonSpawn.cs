using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x77F262AF87D87FAF)]
    public class GcButtonSpawn : NMSTemplate
    {
        /* 0x00 */ public TkInputEnum Button;
		public enum EventEnum { None, Pirates, Police, Traders, Walker }
		public EventEnum Event;
        /* 0x08 */ public GcButtonSpawnOffset Offset;
    }
}
