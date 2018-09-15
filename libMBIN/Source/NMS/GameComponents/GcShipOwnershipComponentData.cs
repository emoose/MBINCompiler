using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0xAD386178B5B83F60)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        public GcSpaceshipComponentData Data;
    }
}
