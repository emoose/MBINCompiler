namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PartID;
        public int Count;
        public GcBuildingPartSearchType Type;
    }
}
