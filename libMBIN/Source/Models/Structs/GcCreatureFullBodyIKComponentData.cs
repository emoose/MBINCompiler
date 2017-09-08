using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcCreatureFullBodyIKComponentData : NMSTemplate        // size: 0x18
    {
        public List<GcCreatureIkData> JointData;
        public int HeadUpAxis;
        public string[] HeadUpAxisValues()
        {
            return new[] { "X", "XNeg", "Y", "YNeg", "Z", "ZNeg" };
        }

        public bool UseFootGlue;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
