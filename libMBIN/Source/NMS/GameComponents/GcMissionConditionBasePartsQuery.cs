using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C26F380281C2DEB, NameHash = 0xDC4640E07A221674)]
    public class GcMissionConditionBasePartsQuery : NMSTemplate
    {
        /* 0x00 */ public GcBasePartSearchFilter PartsSearchFilter;
        /* 0x48 */ public int MinPartsFound;
        /* 0x4C */ public int MaxPartsFound;
        /* 0x50 */ public GcBaseSearchFilter ExcludeBasesFilter;
        /* 0xE8 */ public bool ExcludeGlobalBuffer;
        /* 0xEC */ public float SearchDistanceLimit;
    }
}
