using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x9127953A57042E62)]
    public class GcCustomisationGroups : NMSTemplate
    {
        public List<GcCustomisationGroup> CustomisationGroups;
    }
}
