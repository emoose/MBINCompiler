namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x748A8CF702597D2A, NameHash = 0x6BBA317B)]
    public class GcPetBattlerMoveSetSelection : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MoveSet;
        [NMS(Index = 1)]
        /* 0x10 */ public int Weighting;
    }
}
