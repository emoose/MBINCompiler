﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x8)]
    public class NMSString0x10 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x10)]
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

        public NMSString0x10(string str)
        {
            this.Value = str;
        }

        public NMSString0x10() { }

        public static implicit operator NMSString0x10(string str) => new NMSString0x10(str);
		public static implicit operator string ( NMSString0x10 str ) => str.Value;
	}
}
