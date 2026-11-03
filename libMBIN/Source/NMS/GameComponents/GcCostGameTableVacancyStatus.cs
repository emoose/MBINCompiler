namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC89393D40421116, NameHash = 0xC4C741B6)]
    public class GcCostGameTableVacancyStatus : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public bool CheckGameHasSpaces;
        [NMS(Index = 0)]
        /* 0x1 */ public bool CheckGameIsRegistered;
        [NMS(Index = 3)]
        /* 0x2 */ public bool RequiresGameHasSpaces;
        [NMS(Index = 1)]
        /* 0x3 */ public bool RequiresGameIsRegistered;
    }
}
