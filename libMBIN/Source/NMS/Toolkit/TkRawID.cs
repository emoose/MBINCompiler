namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B73B8BA0886BF755)]
    public class TkRawID : NMSTemplate
    {
        [NMS(Size = 0x8)]
        public string Value0;
        public ulong Value1;
    }
}
