namespace MBINCompiler.Models.Structs
{
    public class TkGameSettings : NMSTemplate
    {
        public int LanguageSetting;
        public string[] LanguageSettingValues()
        {
            return new[] { "default", "english", "french", "italian", "german", "spanish", "russian", "polish", "dutch", "portuguese", "brazilianportuguese", "japanese", "traditionalchinese", "simplifiedchinese", "korean" };
        }

        [NMS(Size = 0x1F)]
        public GcInputActionMapping[] KeyMapping;
    }
}
