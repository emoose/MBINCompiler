using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA1E4368A8C43F84, NameHash = 0xBB170982B7A9B162)]
    public class GcPetCustomisationData : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x0 */ public GcCharacterCustomisationSaveData[] Data;
    }
}
