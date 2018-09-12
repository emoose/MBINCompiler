using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B5428717C07E10EE)]
    public class GcPlayerEffectsComponentData : NMSTemplate
    {
        public float VehicleInOutTime;
        public float VehicleInOutEffectDelay;
        public float VehicleInOutDissolveDelay;
    }
}
