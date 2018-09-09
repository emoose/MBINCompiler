namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x5A0, GUID = 0x8C82EE7094DFA4EA)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0xC)]
        public GcPlayerCharacterState[] CharacterStates;
    }
}
