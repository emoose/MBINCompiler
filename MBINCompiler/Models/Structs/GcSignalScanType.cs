namespace MBINCompiler.Models.Structs
{
    public class GcSignalScanType : NMSTemplate
    {
        public int Type;

        public string[] TypeValues()
        {
            return new[] { "None", "DropPod", "Shelter", "Search", "Relic", "Industrial", "Ship" };
        }
    }
}
