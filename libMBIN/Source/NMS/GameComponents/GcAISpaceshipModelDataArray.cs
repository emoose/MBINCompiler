using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x5BAFF79DDADFC628, NameHash = 0x5CA5E4883985A60B)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        /* 0x0 */ public List<GcAISpaceshipModelData> Spaceships;
    }
}
