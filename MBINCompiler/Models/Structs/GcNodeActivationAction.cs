namespace MBINCompiler.Models.Structs
{
    public class GcNodeActivationAction : NMSTemplate
    {
        public int NodeActiveState;
        public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle" };
        }

        [NMS(Size = 0x80)]
        public string Name;
    }
}
