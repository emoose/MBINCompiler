using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7EB99A1C11C3D004, NameHash = 0x4F5433BCFC028B49)]
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAISpaceshipTypes Type;
        /* 0x04 */ public GcSpaceshipClasses Class;
        /* 0x08 */ public GcPrimaryAxis Axis;
        /* 0x0C */ public TkModelResource Hangar;
        /* 0x90 */ public bool IsSpaceAnomaly;
        /* 0x98 */ public NMSString0x10 CombatDefinitionID;
    }
}
