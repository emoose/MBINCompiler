namespace MBINCompiler.Models.Structs
{
    public class GcNPCWorkerData : NMSTemplate      // size: 0x2C0
    {
        /* 0x000 */ public GcResourceElement ResourceElement;
        /* 0x2A8 */ public GcSeed InteractionSeed;
        /* 0x2B8 */ public bool HasTerminal;
        /* 0x2B9 */ public bool HiredWorker;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2BA */ public byte[] EndPadding;
    }
}
