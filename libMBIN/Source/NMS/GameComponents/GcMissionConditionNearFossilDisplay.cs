namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA867FA8D53178958, NameHash = 0xBA5A7AAE)]
    public class GcMissionConditionNearFossilDisplay : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Distance;
        [NMS(Index = 0)]
        /* 0x4 */ public bool MustBeComplete;
    }
}
