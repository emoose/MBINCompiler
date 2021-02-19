using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x2AB70EB45C9D0D3A, NameHash = 0x9391BB23A2DA934)]
    public class GcCustomisationUI : NMSTemplate
    {
        /* 0x00 */ public GcCustomisationCameraData RacesCameraData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x34 */ public byte[] Padding34;
        /* 0x38 */ public List<GcCustomisationRace> Race;
        /* 0x48 */ public GcCustomisationGroups Common;
    }
}
