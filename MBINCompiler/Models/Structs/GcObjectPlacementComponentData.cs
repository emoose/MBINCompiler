namespace MBINCompiler.Models.Structs
{
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string GroupNodeName;

        public int ActivationType;
        public float FractionOfNodesActive;
        public int MaxNodesActivated;
        public int MaxGroupsActivated;
        public bool UseRaycast;
    }
}
