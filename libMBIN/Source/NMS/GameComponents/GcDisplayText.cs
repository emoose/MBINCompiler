using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA22DB14A469ED818, NameHash = 0x39E3C3DE16466069)]
    public class GcDisplayText : NMSTemplate
    {
        // size: 0x5
        public enum HUDTextDisplayTypeEnum {
            Full,
            Compact,
            EyeLevel,
            Prompt,
            Tooltip,
        }
        /* 0x000 */ public HUDTextDisplayTypeEnum HUDTextDisplayType;
        /* 0x004 */ public NMSString0x100 Title;
        /* 0x104 */ public NMSString0x100 Subtitle1;
        /* 0x204 */ public NMSString0x100 Subtitle2;
        /* 0x304 */ public GcAlienRace UseAlienLanguage;
        /* 0x308 */ public List<NMSString0x20A> ChooseRandomTextOptions;
    }
}
