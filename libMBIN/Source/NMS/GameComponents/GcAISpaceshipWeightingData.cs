namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB164EA8EF150DFDC, NameHash = 0xD66342935A1B2735)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        // size: 0x9
        public enum CivilianClassWeightingsEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        [NMS(Size = 0x9, EnumType = typeof(CivilianClassWeightingsEnum))]
        /* 0x0 */ public float[] CivilianClassWeightings;
    }
}
