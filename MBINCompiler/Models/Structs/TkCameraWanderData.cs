namespace MBINCompiler.Models.Structs
{
    public class TkCameraWanderData : NMSTemplate
    {
        public bool CamWander;
        public float CamWanderPhase;
        public float CamWanderAmplitude;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC;
    }
}
