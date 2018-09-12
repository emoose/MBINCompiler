namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4D86CADD1E49AD2)]
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "C", "B", "A", "S" })]
        public float[] ClassProbabilities;
    }
}
