namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x99D365A4D96CB687, NameHash = 0x20FD4240)]
    public class TkRigidBodyComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSTemplate Properties;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSTemplate VolumeData;
        // size: 0x3
        public enum TargetNodeEnum : uint {
            Model,
            MasterModel,
            Attachment,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public TargetNodeEnum TargetNode;
        [NMS(Index = 2)]
        /* 0x24 */ public bool AddToWorldImmediately;
        [NMS(Index = 1)]
        /* 0x25 */ public bool AddToWorldOnPrepare;
    }
}
