using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x86B61CEEE4451AD)]
    public class TkLanguages : NMSTemplate
    {
		public enum LanguageEnum { Default, English, USEnglish, French, Italian, German, Spanish, Russian, Polish, Dutch, Portuguese, LatinAmericanSpanish, BrazilianPortuguese, Japanese, TraditionalChinese, SimplifiedChinese, Korean }
		public LanguageEnum Language;
    }
}
