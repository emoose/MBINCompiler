using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4427F5393CBA3DBA, NameHash = 0x8005E8FA6CB39C35)]
    public class GcCostInteractionIndex : NMSTemplate
    {
        /* 0x00 */ public GcInteractionType InteractionType;
        /* 0x04 */ public GcAlienRace Race;
        /* 0x08 */ public int Index;
        /* 0x0C */ public bool AffordIfGreaterThanIndex;
        /* 0x10 */ public NMSString0x20A CantAffordLocID;
    }
}
