namespace libMBIN.Models.Structs
{
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "C", "B", "A", "S" })]
        public float[] ClassProbabilities;
    }
}
