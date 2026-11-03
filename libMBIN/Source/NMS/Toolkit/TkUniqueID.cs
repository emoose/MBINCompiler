using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD8FEDF2F8A026079, NameHash = 0x6550F7AB)]
    public class TkUniqueID : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public ulong Address;
        [NMS(Index = 2)]
        /* 0x08 */ public ulong Index;
        [NMS(Index = 0)]
        /* 0x10 */ public TkSaveID OwnerID;
    }
}
