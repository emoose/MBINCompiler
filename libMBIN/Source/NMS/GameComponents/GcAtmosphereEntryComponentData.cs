namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x30, GUID = 0x1FA54D54FA89D565)]
    public class GcAtmosphereEntryComponentData : NMSTemplate
    {
        public bool AutEntry;
        public float EntryTime;
        public float EntryOffset;
        public float EditTerrainRadius;
        [NMS(Size = 0x10)]
        public string ImpactEffect;
        [NMS(Size = 0x10)]
        public string FlareEffect;
    }
}
