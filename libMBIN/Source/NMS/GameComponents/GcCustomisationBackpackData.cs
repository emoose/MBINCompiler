namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54939011C26E85F9, NameHash = 0xEA80BCC2)]
    public class GcCustomisationBackpackData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f ActiveJetOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 NodeName;
    }
}
