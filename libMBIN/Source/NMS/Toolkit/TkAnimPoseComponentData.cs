using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9AF9F16D7C4BE594, NameHash = 0x6DF806B869216436)]
    public class TkAnimPoseComponentData : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimPoseData> PoseAnims;
        /* 0x10 */ public NMSString0x80 Filename;
        /* 0x90 */ public List<TkAnimPoseCorrelationData> Correlations;
        /* 0xA0 */ public List<TkAnimPoseExampleData> Examples;
        /* 0xB0 */ public List<float> CorrelationMat;
        /* 0xC0 */ public float AdultCorrelationValue;
        /* 0xC8 */ public List<TkAnimPoseBabyModifier> BabyModifiers;
        /* 0xD8 */ public bool ShouldRandomise;
    }
}
