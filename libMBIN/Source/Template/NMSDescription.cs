using System;

namespace libMBIN
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Class)]
    public class NMSDescription : Attribute
    {
        public string Description { get; set; }

        public NMSDescription(string description)
        {
            this.Description = description;
        }
    }
}