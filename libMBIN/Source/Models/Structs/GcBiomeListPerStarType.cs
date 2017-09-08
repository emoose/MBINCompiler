namespace libMBIN.Models.Structs
{
    public class GcBiomeListPerStarType : NMSTemplate       // size: 0x110
    {
        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x000 */ public GcBiomeList[] StarType;

        /* 0x0A0 */ public GcBiomeList LushYellow;
        /* 0x0C8 */ public GcBiomeList AbandonedYellow;

        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x0F0 */ public float[] LifeChance;

        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x100 */ public float[] AbandonedLifeChance;
    }
}
