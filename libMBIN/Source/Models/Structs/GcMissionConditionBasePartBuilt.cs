namespace libMBIN.Models.Structs
{
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PartID;
        public int Count;
        public GcBuildingPartSearchType Type;
    }
}
