namespace MBINCompiler.Models.Structs
{
    public class GcButtonSpawn : NMSTemplate        // size: 0x28       // in a global?
    {
        /* 0x00 */ public TkInputEnum Button;
        public int Event;
        /* 0x04 */ public string[] EventValues()
        {
            return new[] { "None", "Pirates", "Police", "Traders", "Walker" };
        }
        /* 0x08 */ public GcButtonSpawnOffset Offset;
    }
}
