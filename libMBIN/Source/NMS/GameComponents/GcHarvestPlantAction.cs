using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x11DDE0F1D2E56DD7, NameHash = 0x5234EE3175AF8A4A)]
    // Used in a global?? 41C80000h
    public class GcHarvestPlantAction : NMSTemplate
    {
        public float Radius;
    }
}
