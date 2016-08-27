using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNodeActivationAction : NMSTemplate
    {
        public int NodeActiveState;
        public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle" };
        }

        [NMS(Size = 0x80)]
        public string Name;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding84;
    }
}
