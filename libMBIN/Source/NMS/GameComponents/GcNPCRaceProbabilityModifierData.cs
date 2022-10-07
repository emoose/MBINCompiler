using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9357CE2D883EA72, NameHash = 0x7C31C15F3BD6DD7E)]
    public class GcNPCRaceProbabilityModifierData : NMSTemplate
    {
        /* 0x0 */ public GcAlienRace Race;
        /* 0x4 */ public float Modifier;
    }
}
