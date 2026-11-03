namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x792A846791CB0AE3, NameHash = 0x54DD2606)]
    public class GcGameTableDiceConfigFaceData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f FaceNormalDir;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSTemplate Result;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20 Locator;
    }
}
