using System;

namespace libMBIN
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NMSAlignment : Attribute
    {
        public int Alignment { get; set; } = 4;

        public NMSAlignment(int alignment)
        {
            this.Alignment = alignment;
        }
    }
}