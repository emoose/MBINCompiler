using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6E0AC82EC2201438, NameHash = 0x367D7C3)]
    public class TkAnimStateMachineLayerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkAnimStateMachineData StateMachineContainer;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Id;
    }
}
