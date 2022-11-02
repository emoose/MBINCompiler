using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB4CCAB85E91EEDD1, NameHash = 0x18F53DCA811C8E56)]
    public class TkGameSettings : NMSTemplate
    {
        // size: 0xF
        public enum LanguageSettingEnum {
            Default,
            english,
            french,
            italian,
            german,
            spanish,
            russian,
            polish,
            dutch,
            portuguese,
            brazilianportuguese,
            japanese,
            traditionalchinese,
            simplifiedchinese,
            korean
        }
        /* 0x00 */ public LanguageSettingEnum LanguageSetting;
        /* 0x08 */ public List<GcInputActionMapping> KeyMapping;
        /* 0x18 */ public List<GcInputActionMapping2> KeyMapping2;
    }
}
