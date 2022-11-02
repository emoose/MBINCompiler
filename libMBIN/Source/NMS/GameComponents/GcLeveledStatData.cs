using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98FC6E1D23F2EB4F, NameHash = 0x987EE8E8873AED6B)]
    public class GcLeveledStatData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 StatId;
        /* 0x010 */ public NMSString0x20A StatTitle;
        // size: 0x3
        public enum StatMessageTypeEnum {
            Full,
            Quick,
            Silent
        }
        /* 0x030 */ public StatMessageTypeEnum StatMessageType;
        /* 0x038 */ public NMSString0x20A NotifyMessage;
        /* 0x058 */ public NMSString0x20A NotifyMessageSingular;
        /* 0x078 */ public bool ShowInTerminal;
        /* 0x079 */ public bool ShowStatLevel;
        /* 0x07C */ public TkTextureResource Icon;
        [NMS(Size = 0xB)]
        /* 0x100 */ public GcStatLevelData[] StatLevels;
        /* 0x680 */ public bool UseRankNotStats;
        /* 0x681 */ public bool TelemetryUpload;
    }
}
