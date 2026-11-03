namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7CE6EC257BFEF9D7, NameHash = 0x3C58F148)]
    public class TkWaterCondition : NMSTemplate
    {
        // size: 0xF
        public enum WaterConditionEnum : uint {
            Absolutely_Tranquil,
            Breezy_Lake,
            Wavy_Lake,
            Still_Pond,
            Agitated_Pond,
            Agitated_Lake,
            Surf,
            Big_Surf,
            Chaotic_Sea,
            Huge_Swell,
            Choppy_Sea,
            Very_Choppy_Sea,
            White_Horses,
            Ocean_Planet,
            Wall_Of_Water,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WaterConditionEnum WaterCondition;
    }
}
