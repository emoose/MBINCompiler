namespace MBINCompiler.Models.Structs
{
    public class GcShipFlareComponentData : NMSTemplate
    {
        public int FlareType;
        public string[] FlaseTypeValues()
        {
            return new[] { "Default"};
        }
    }
}
