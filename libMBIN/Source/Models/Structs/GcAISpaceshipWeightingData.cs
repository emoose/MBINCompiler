namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x1C, GUID = 0x0B164EA8EF150DFDC)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter", "Royal" })]
        public float[] CivilianClassWeightings;
    }
}
