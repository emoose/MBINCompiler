using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x108, GUID = 0xB91B7A3E54C562E4, NameHash = 0xBB170982B7A9B162)]
    public class GcPetCustomisationData : NMSTemplate
    {
        [NMS(Size = 0x3)]
        public GcCharacterCustomisationSaveData[] Data;
    }
}
