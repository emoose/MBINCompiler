namespace MBINCompiler.Models.Structs
{
    public class GcSolarSystemClass : NMSTemplate
    {
        public int SolarSystemClass;
        public string[] SolarSystemClassValues()
        {
            return new[] { "Default", "Initial", "Anomaly", "GameStart" };
        }
    }
}
