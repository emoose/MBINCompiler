namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x910EDE615190BBFF, NameHash = 0xF4173254)]
    public class GcRewardJetpackBoost : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Duration;
        [NMS(Index = 1)]
        /* 0x4 */ public float ForwardBoost;
        [NMS(Index = 3)]
        /* 0x8 */ public float IgnitionBoost;
        [NMS(Index = 2)]
        /* 0xC */ public float UpBoost;
    }
}
