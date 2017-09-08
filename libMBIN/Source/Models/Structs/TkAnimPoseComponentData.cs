using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkAnimPoseComponentData : NMSTemplate      // size: 0xC8
    {
        public List<TkAnimPoseData> PoseAnims;

        [NMS(Size = 0x80)]
        public string Filename;

        public List<TkAnimPoseCorrelationData> Correlations;
        public List<TkAnimPoseExampleData> Examples;
        public List<float> CorrelationMat;

        public float AdultCorrelationValue;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
    }
}
