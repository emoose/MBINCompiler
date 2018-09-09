namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A7B4537251A00C02)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;        // I bet this has got bigger...
        public int RepairedComponents;
    }
}
