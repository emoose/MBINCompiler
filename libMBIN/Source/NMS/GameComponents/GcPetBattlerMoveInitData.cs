namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C2C57DB86E6A25B, NameHash = 0xE810FB06)]
    public class GcPetBattlerMoveInitData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MoveTemplateID;
        [NMS(Index = 1)]
        /* 0x10 */ public int Cooldown;
        [NMS(Index = 2)]
        /* 0x14 */ public float ScoreBoost;
    }
}
