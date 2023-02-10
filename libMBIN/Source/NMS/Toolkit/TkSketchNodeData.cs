using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x737644F5760BE32E, NameHash = 0x34A0F43E0ECB3765)]
    public class TkSketchNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 TypeName;
        // size: 0x6
        public enum TriggerTypeEnum {
            Disabled,
            Interrupt,
            RunParallel,
            Blocked,
            QueueLatest,
            QueueAll,
        }
        /* 0x20 */ public TriggerTypeEnum TriggerType;
        /* 0x24 */ public int SelectedVariant;
        /* 0x28 */ public int PositionX;
        /* 0x2C */ public int PositionY;
        /* 0x30 */ public List<TkSketchNodeConnections> Connections;
        /* 0x40 */ public List<byte> CustomData;
    }
}
