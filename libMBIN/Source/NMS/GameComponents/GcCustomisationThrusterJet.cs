using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x128, GUID = 0xAEE0AFFF6B07EC25, NameHash = 0x73B8C106776DC488)]
    public class GcCustomisationThrusterJet : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LocatorPrefix;
        /* 0x10 */ public NMSString0x10 Effect;
        /* 0x20 */ public TkTextureResource JetMesh;
        /* 0xA4 */ public TkTextureResource Trail;
    }
}
