namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x12D45A89840E0777)]
    public class TkVolumeTriggerType : NMSTemplate
    {
		public enum VolumeTriggerTypeEnum { Open, GenericInterior, GenericGlassInterior, Corridor, SmallRoom, LargeRoom, OpenCovered, HazardProtection, FieldBoundary, Custom_Biodome, Portal, VehicleBoost }
		public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
