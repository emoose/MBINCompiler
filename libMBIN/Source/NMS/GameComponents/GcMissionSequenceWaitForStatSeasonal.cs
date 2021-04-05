using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x128, GUID = 0x0000000000000000, NameHash = 0xCEBA3C32BCAF04F6)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Stat;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string StatGroup;
        /* 0x0A0 */ public int Amount;
        /* 0x0A4 */ public bool TakeAmountFromSeasonalData;
        [NMS(Size = 0x80)]
        /* 0x0A5 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x125 */ public byte[] EndPadding;
    }
}
