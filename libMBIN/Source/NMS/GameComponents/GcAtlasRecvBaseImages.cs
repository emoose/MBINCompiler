using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x7129073650A35082, NameHash = 0xC3C14D18029FA426)]
    public class GcAtlasRecvBaseImages : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public int NumberOfImages;
        /* 0x14 */ public int DataTimestamp;
        /* 0x18 */ public ulong ImageDataPtr;
        /* 0x20 */ public int ImageDataSize;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
