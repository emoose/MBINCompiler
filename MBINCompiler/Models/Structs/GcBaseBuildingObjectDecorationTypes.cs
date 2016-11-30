using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        public int BaseBuildingDecorationType;
        public string[] BaseBuildingDecorationTypeValues()
        {
            return new[] { "Normal", "SurfaceNormal", "Ceiling", "Terrain", "Substance", "Interior", "Exterior", "Plant"};
        }
    }
}
