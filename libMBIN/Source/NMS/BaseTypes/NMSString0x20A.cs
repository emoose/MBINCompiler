﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    /// <summary>
    /// This is a modified version of the NMSString0x20 which is aligned (hence the 'A' in the name) to 0x8.
    /// </summary>
    [NMS(Size = 0x20, Alignment = 0x8)]
    public class NMSString0x20A : NMSTemplate, INMSString
    {
        // This is a modified version of the NMSString0x20 which is aligned (hence the 'A' in the name) to 0x8.
        [NMS(Size = 0x20)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        /// <summary>
        /// Returns the value held by this string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Value;
        }

        public NMSString0x20A(string str)
        {
            this.Value = str;
        }

        public NMSString0x20A() { }

        public static implicit operator NMSString0x20A ( string str ) => new NMSString0x20A(str);
        public static implicit operator string ( NMSString0x20A str ) => str.Value;
        public static implicit operator NMSString0x20A ( NMSString0x20 str) => new NMSString0x20A(str.Value);
        public static implicit operator NMSString0x20 (NMSString0x20A str) => new NMSString0x20(str.Value);
    }
}
