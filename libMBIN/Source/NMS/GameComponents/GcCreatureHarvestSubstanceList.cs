namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CC1A1955A4F2E63, NameHash = 0xC8FD5EE28A99CF03)]
    public class GcCreatureHarvestSubstanceList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CreatureType;
        /* 0x10 */ public NMSString0x10 Item;
        /* 0x20 */ public NMSString0x80 Desc;
        /* 0xA0 */ public int MinBlobs;
    }
}
