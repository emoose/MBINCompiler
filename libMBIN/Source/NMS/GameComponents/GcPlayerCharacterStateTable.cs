using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58B5A60C2A56F87E, NameHash = 0xDE03C95CFD766DA8)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0x12, EnumType = typeof(GcPlayerCharacterStateType.CharacterStateEnum))]
        /* 0x0 */ public GcPlayerCharacterStateData[] CharacterStates;
    }
}
