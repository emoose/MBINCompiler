using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x73A9CDAF4AF83232)]
    public class TkLSystemRestrictionData : NMSTemplate
    {
        public int Amount;
		public enum RestrictionEnum { NoMoreThan, AtLeast, AtLeastIfICan }
		public RestrictionEnum Restriction;
    }
}
