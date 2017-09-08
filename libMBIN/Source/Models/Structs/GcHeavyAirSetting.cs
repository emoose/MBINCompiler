namespace MBINCompiler.Models.Structs
{
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcHeavyAirSettingValues[] Settings;
    }
}
