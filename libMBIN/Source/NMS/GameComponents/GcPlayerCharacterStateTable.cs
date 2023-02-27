using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5A07A8BE7FF697F, NameHash = 0xDE03C95CFD766DA8)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0x12, EnumType = typeof(GcPlayerCharacterStateType.CharacterStateEnum))]
        /* 0x0 */ public GcPlayerCharacterStateData[] CharacterStates;
    }
}
