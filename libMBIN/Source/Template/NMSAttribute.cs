using System;

namespace libMBIN
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Class)]
    public class NMSAttribute : Attribute
    {
        public int Size { get; set; }
        public bool Ignore { get; set; }
        public object DefaultValue { get; set; }
        public string[] EnumValue { get; set; }
        public int Padding { get; set; }
        public int Alignment { get; set; } = 4;
        public ulong GUID { get; set; }
    }
}