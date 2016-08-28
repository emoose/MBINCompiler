using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPainAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Damage;
        public float Radius;
        public bool AffectsPlayer;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
