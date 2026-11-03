namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x585DD40510FE625E, NameHash = 0x4EBBAC7C)]
    public class GcLaunchFuelCostDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum LaunchFuelCostDifficultyEnum : uint {
            Free,
            Low,
            Normal,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LaunchFuelCostDifficultyEnum LaunchFuelCostDifficulty;
    }
}
