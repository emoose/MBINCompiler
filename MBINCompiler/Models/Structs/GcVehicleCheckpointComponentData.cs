namespace MBINCompiler.Models.Structs
{
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
        public int CheckpointType;
        public string[] CheckpointTypeValues()
        {
            return new[] { "Checkpoint", "Start", "Finish"};
        }
    }
}
