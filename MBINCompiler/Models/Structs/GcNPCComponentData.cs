namespace MBINCompiler.Models.Structs
{
    public class GcNPCComponentData : NMSTemplate
    {
        public GcAlienRace AlienRace;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;
    }
}
