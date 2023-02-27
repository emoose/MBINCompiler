using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB9CF5F265C56FBC, NameHash = 0x5CA5E4883985A60B)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        /* 0x0 */ public List<GcAISpaceshipModelData> Spaceships;
    }
}
