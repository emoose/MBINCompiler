using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x0F753F635691AC4D)]
    public class GcExpeditionEventTable : NMSTemplate
    {
        public List<GcExpeditionEventData> Events;
        public List<GcExpeditionInterventionEventData> InterventionEvents;
    }
}
