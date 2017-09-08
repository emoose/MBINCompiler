using System.Collections.Generic;

namespace libMBIN.Models.Structs       // size: 0x30
{
    public class GcTriggerActionComponentData : NMSTemplate
    {
        public bool HideModel;
        public bool StartInactive;
        [NMS(Size = 0x6, Ignore =true)]
        public byte[] Padding2;
        public List<GcActionTriggerState> States;
        public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
        [NMS(Size = 0x10)]
        public string PersistentState;
    }
}
