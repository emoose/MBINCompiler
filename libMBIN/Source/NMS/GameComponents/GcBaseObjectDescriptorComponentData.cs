namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DB35DCE320476B, NameHash = 0xA075B3D2)]
    public class GcBaseObjectDescriptorComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename ProcSceneFile;
        [NMS(Index = 1)]
        /* 0x10 */ public bool ForceShowPickUpLabel;
    }
}
