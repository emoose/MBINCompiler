namespace MBINCompiler.Models.Structs
{
    public class GcScanEventSave : NMSTemplate
    {
        public int Table;

        public string Event;

        public string GalacticAddress;

        public BuildingSeed BuildingSeed;

        public GcBuildingClassification BuildingClass; // Not sure about this one
    }

    public class BuildingSeed : NMSTemplate
    {
        public bool Use_Seed_Value;
        public string Seed;
    }
}
