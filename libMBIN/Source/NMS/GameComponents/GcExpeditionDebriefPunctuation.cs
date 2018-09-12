namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x24, GUID = 0x0BD8A11BC4589CBE8)]
    public class GcExpeditionDebriefPunctuation : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Punctuation;
        public float Delay;
    }
}
