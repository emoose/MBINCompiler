using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkAnimNodeFrameData : NMSTemplate
    {
        public List<Vector4f> Rotations;
        public List<Vector4f> Translations; // actually Vector3f
        public List<Vector4f> Scales; // actually Vector3f
    }
}
