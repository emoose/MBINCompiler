using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x9127953A57042E62)]
    public class GcCustomisationGroups : NMSTemplate
    {
        public List<GcCustomisationGroup> CustomisationGroups;
    }
}
