using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0xF52BA83C79ECB661, NameHash = 0xB4FC959D6A910DEB)]
    public class GcNPCNavigationAreaComponentData : NMSTemplate
    {
        public enum NavAreaTypeEnum { Normal, BuildingWithExterior , Debris, Ship, Mech, PlanetMech }
        public NavAreaTypeEnum NavAreaType;
        public float MinRadius;
        public float MaxRadius;
        public float SphereCastHeightClearance;         // 3F000000h
        public float NeighbourCandidateDistance;        // 41100000h
        public float MaxNeighbourSlope;                 // 41200000h
        public float ConnectionLengthFactor;            // 3F4CCCCDh
    }
}
