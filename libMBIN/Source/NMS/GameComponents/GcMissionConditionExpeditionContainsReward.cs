using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x63104B450CBA7BF4, NameHash = 0xD07BDFE4B607638E)]
    public class GcMissionConditionExpeditionContainsReward : NMSTemplate
    {
        /* 0x0 */ public NMSString0x10 RewardID;
    }
}
