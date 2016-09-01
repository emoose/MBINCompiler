using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkMaterialUniform : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }
}
