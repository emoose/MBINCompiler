using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x6DAB1474F9B0A50B)]
    public class TkLanguagesAllowedData : NMSTemplate
    {
        public List<TkLanguages> Allowed;
        public TkLanguages Language;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
