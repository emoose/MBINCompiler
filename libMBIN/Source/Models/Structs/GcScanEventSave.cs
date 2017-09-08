namespace libMBIN.Models.Structs
{
    public class GcScanEventSave : NMSTemplate // 0x50 bytes
    {
        public int Table;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        [NMS(Size = 0x10)]
        public string Event;

        public ulong GalacticAddress;

        public GcSeed BuildingSeed;

        public Vector4f BuildingLocation;

        public GcBuildingClassification BuildingClass;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding44;
    }
}
