using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD7A9C0E602A687A, NameHash = 0xE7E606D9)]
    public class GcCustomisationBoneScales : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GroupTitle;
        [NMS(Index = 2)]
        /* 0x20 */ public List<float> Positions;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 ScaleBoneName;
    }
}
