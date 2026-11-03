namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3E3032D7A3F2EA22, NameHash = 0xB7832FA2)]
    public class TkPhysicsWorldComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool OwnerPhysicsAllowKinematic;
        [NMS(Index = 1)]
        /* 0x1 */ public bool OwnerPhysicsUseLocalModelOnly;
    }
}
