using System;

namespace libMBIN
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Class)]
    public class NMSAttribute : Attribute
    {
        public int Size { get; set; }
        public bool Ignore { get; set; }
        public Type EnumType { get; set; }
        public int Alignment { get; set; }
        public ulong GUID { get; set; }
        public uint NameHash { get; set; }
        public bool Broken { get; set; }
        public string KeyField { get; set; } = "";
        public int Index { get; set; }
        public string MxmlName { get; set; }
    }
}