using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x318, GUID = 0x67991AA77D99A38E, NameHash = 0x39E3C3DE16466069)]
    public class GcDisplayText : NMSTemplate
    {
		public enum HUDTextDisplayTypeEnum { Full, Compact, EyeLevel, Prompt, Tooltip }
		/* 0x000 */ public HUDTextDisplayTypeEnum HUDTextDisplayType;
        [NMS(Size = 0x100)]
        /* 0x004 */ public string Title;
        [NMS(Size = 0x100)]
        /* 0x104 */ public string Subtitle1;
        [NMS(Size = 0x100)]
        /* 0x204 */ public string Subtitle2;
        /* 0x304 */ public GcAlienRace UseAlienLanguage;
        /* 0x308 */ public List<NMSString0x20> ChooseRandomTextOptions;
    }
}
