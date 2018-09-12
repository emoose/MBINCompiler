using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x0B84FEECD3EC4E5E8)]
    public class GcCustomisationPresets : NMSTemplate
    {
        public List<GcCustomisationPreset> Presets;
    }
}
