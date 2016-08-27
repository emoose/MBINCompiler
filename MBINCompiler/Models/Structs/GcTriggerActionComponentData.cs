using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcTriggerActionComponentData : NMSTemplate
    {
        public bool HideModel;
        public bool StartInactive;
        public List<GcActionTriggerState> States;
        public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
        [NMS(Size = 0x10)]
        public string PersistentState;
    }
}
