using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkAnimPoseComponentData : NMSTemplate
    {
        public List<TkAnimPoseData> PoseAnims;

        [NMS(Size = 0x80)]
        public string Filename;

        public List<TkAnimPoseCorrelationData> Correlations;
        public List<TkAnimPoseExampleData> Examples;
        public List<float> CorrelationMat;

        public float AdultCorrelationValue;
    }
}
