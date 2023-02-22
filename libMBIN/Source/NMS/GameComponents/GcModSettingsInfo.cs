using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF658C5CC0A4A78DE, NameHash = 0xC0CE6220E5E98BD9)]
    public class GcModSettingsInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Name;
        /* 0x080 */ public NMSString0x80 Author;
        /* 0x100 */ public ulong ID;
        /* 0x108 */ public ulong AuthorID;
        /* 0x110 */ public ulong LastUpdated;
        /* 0x118 */ public ushort LoadOrder;
        /* 0x11A */ public bool Enabled;
        /* 0x11B */ public bool EnabledVR;
        /* 0x120 */ public List<ulong> Dependencies;
    }
}
