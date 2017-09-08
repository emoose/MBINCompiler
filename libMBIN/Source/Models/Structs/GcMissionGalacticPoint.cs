namespace libMBIN.Models.Structs
{
    public class GcMissionGalacticPoint : NMSTemplate      // size: 0x4
    {
        public int GalacticPoint;
        public string[] GalacticPointValues()
        {
            return new[] { "Atlas", "BlackHole" };
        }
    }
}
