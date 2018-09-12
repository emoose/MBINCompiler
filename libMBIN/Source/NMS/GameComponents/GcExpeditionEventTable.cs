using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x20, GUID = 0x0F753F635691AC4D)]
    public class GcExpeditionEventTable : NMSTemplate
    {
        public List<GcExpeditionEventData> Events;
        public List<GcExpeditionInterventionEventData> InterventionEvents;
    }
}
