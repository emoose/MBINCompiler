using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xF65578386A25C171, NameHash = 0xF460B1FDC0499CEA)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        public List<GcCreatureRoleData> AvailableRoles;
        public float MaxProportionFlying;
        public bool HasSandWorms;
        public float SandWormFrequency;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}