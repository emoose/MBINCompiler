namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF08CFE6039197B2C, NameHash = 0xB8138F7D4F230C2B)]
    public class GcLaunchFuelCostDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum LaunchFuelCostDifficultyEnum {
            Free,
            Low,
            Normal,
            High
        }
        /* 0x0 */ public LaunchFuelCostDifficultyEnum LaunchFuelCostDifficulty;
    }
}
