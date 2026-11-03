using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7E31E051EB2F599, NameHash = 0xFED86EB9)]
    public class GcPlayerAttributesEvent : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcEnvironmentLocation> CheckPlayerIsInOneOfTheseEnvironments;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcEnvironmentLocation> CheckPlayerIsNotInOneOfTheseEnvironments;
        [NMS(Index = 0)]
        /* 0x20 */ public bool CheckSpaceWalking;
        [NMS(Index = 1)]
        /* 0x21 */ public bool IsSpaceWalking;
    }
}
