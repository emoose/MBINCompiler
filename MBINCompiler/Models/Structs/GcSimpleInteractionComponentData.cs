namespace MBINCompiler.Models.Structs
{
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        public int SimpleInteractionType;
        public string[] SimpleInteractionTypeValues()
        {
            return new[] { "Interact", "Treasure", "Beacon", "Scan", "Save", "CallShip", "Word", "Tech", "GenericReward", "Feed" };
        }

        public float InteractDistance;
        [NMS(Size = 0x10)]
        public string Id;

        public GcRarity Rarity;
        public GcSizeIndicator SizeIndicator;
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public bool BroadcastTriggerAction;
        public float Delay;

        public bool InteractIsCrime;
        public int InteractCrimeLevel;
        public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x20)]
        public string Name;
    }
}
