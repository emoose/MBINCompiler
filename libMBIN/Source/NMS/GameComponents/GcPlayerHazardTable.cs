using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x210, GUID = 0x234DE601620B66D9, NameHash = 0xCC978CCE3CFE915B)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        public GcPlayerHazardData[] Table;
    }
}