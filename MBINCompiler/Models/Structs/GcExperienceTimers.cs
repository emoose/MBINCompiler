namespace MBINCompiler.Models.Structs
{
    public class GcExperienceTimers : NMSTemplate       // probably used in a global
    {
	  /* 0x00 */ public int HighChance;
	  /* 0x04 */ public int LowChance;
	  /* 0x08 */ public Vector2f High;
	  /* 0x10 */ public Vector2f Normal;
	  /* 0x18 */ public Vector2f Low;
    }
}
