namespace MBINCompiler.Models.Structs
{
    public class GcGoToStateAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string State;

        public bool Broadcast;
        public int BroadcastLevel;
        public string[] BroadcastLevelValues()
        {
            return new[] { "Scene", "LocalModel" };
        }
    }
}
