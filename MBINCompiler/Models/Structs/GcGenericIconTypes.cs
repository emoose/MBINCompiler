namespace MBINCompiler.Models.Structs
{
    public class GcGenericIconTypes : NMSTemplate
    {
        public int GenericIconType;
        public string[] GenericIconTypeValues()
        {
            return new[] { "None", "Interaction", "SpaceStation", "SpaceAnomaly", "SpaceAtlas" };
        }
    }
}
