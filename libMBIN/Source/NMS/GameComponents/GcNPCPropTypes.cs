using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5A0389A6ECF0D075)]
    public class GcNPCPropTypes : NMSTemplate
    {
		public enum NPCPropEnum { None, IPad, HoloBlob, HoloFrigate, HoloShip, HoloMultitool, HoloSolarSystem, Container, Box, Cup, DontCare, RandomHologram }
		public NPCPropEnum NPCProp;
    }
}
