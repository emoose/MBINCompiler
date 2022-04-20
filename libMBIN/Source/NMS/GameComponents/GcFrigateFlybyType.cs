using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x870C7F2FD8193366, NameHash = 0x20BC4D823F8443DB)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        // size: 0x3
        public enum FrigateFlybyTypeEnum { SingleShip, AmbientGroup, ScriptedGroup }
        /* 0x0 */ public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
