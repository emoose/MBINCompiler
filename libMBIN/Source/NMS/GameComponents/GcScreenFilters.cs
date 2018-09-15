using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xCC32B001DAE0D493)]
    public class GcScreenFilters : NMSTemplate
    {
		public enum ScreenFiltersEnum { Default, DefaultStorm, Frozen, FrozenStorm, Toxic, ToxicStorm, Radioactive, RadioactiveStorm, Scorched, ScorchedStorm, Barren, BarrenStorm, Weird1, Weird2, Weird3, Weird4, Weird5, Weird6, Weird7, Weird8, Vintage, HyperReal, Desaturated, Amber, GBGreen, Apocalypse, Diffusion, Green, BlackAndWhite, Isolation, Sepia, Filmic, GBGrey, Binoculars }
		public ScreenFiltersEnum ScreenFilters;
    }
}
