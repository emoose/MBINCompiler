using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x310, GUID = 0x28ACFF2ACCF00323, NameHash = 0x56B367D500FF0878)]
    public class GcAtlasSendSubmitBaseWithImage : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public GcAtlasSendSubmitBase Base;
        /* 0x300 */ public List<byte> Image;        // This is not the correct type. The data will literally be the data for the image itself.
        // The above data type is the same as the MeshDataStream in the TkMeshData...
    }
}
