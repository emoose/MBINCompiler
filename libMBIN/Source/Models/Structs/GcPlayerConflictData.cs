namespace MBINCompiler.Models.Structs
{
    public class GcPlayerConflictData : NMSTemplate
    {
        public int ConflictLevel;
        public string[] ConflictLevelValues()
        {
            return new[]
            {
                "Low", "Default", "High"
            };
        }
    }
}
