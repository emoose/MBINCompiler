namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E89965A1A5F0BECA)]
    public class GcAISpaceshipComponentData : NMSTemplate       // size: 0x94;
    {
        /* 0x00 */ public GcAISpaceshipTypes Type;
        /* 0x04 */ public GcSpaceshipClasses Class;
        /* 0x08 */ public GcPrimaryAxis Axis;
        /* 0x0C */ public TkTextureResource Hangar;
        /* 0x90 */ public bool IsSpaceAnomaly;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x91 */ public byte[] EndPadding;
    }
}
