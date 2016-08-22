namespace MBINCompiler.Models.Structs
{
    public class GcStatType : NMSTemplate // not the same as GcStatsTypes
    {
        public int StatType;
        public string[] StatTypeValues()
        {
            return new[] { "Int", "Float", "AvgRate" };
        }
    }
}
