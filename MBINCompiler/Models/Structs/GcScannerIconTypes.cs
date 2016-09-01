namespace MBINCompiler.Models.Structs
{
    public class GcScannerIconTypes : NMSTemplate
    {
        public int ScanIconType;
        public string[] ScanIconTypeValues()
        {
            return new[]
            {
                "None", "Health", "Shield", "Hazard", "Tech", "Signal", "Fuel", "Mineral", "Multi", "Artifact", "TechRecipe", "RareProp"
            };
        }
    }
}
