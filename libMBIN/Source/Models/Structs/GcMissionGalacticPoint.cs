namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1A248F0F98435D2F)]
    public class GcMissionGalacticPoint : NMSTemplate      // size: 0x4
    {
		public enum GalacticPointEnum { Atlas, BlackHole }
		public GalacticPointEnum GalacticPoint;
    }
}
