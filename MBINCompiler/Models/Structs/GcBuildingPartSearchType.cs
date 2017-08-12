namespace MBINCompiler.Models.Structs
{
    public class GcBuildingPartSearchType : NMSTemplate
    {
        public int BuildPartSearchType;
        public string[] BuildPartSearchTypeValues()
        {
            return new[] { "Base", "Freighter", "AllPlayerOwned", "OtherPlayerBase"};
        }
    }
}
