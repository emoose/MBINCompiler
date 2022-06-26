﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x800, Alignment = 0x1)]
    public class NMSString0x800 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x800)]
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
            return Value;
        }

        public NMSString0x800(string str)
        {
            this.Value = str;
        }

        public NMSString0x800() { }

		public static implicit operator NMSString0x800 ( string str ) => new NMSString0x800(str);
		public static implicit operator string ( NMSString0x800 str ) => str.Value;
	}
}
