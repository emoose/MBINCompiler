using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcPlanetBuildingData : NMSTemplate // size = 0x18
    {
        public List<GcBuildingSpawnData> Buildings;
        public float Spacing;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding14;
    }
}
