namespace MBINCompiler.Models.Structs
{
    public class GcDestroyAction : NMSTemplate
    {
        public bool DestroyAll;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding1;
    }
}
