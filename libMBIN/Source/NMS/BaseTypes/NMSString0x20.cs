﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x20, Alignment = 0x1)]
    public class NMSString0x20 : NMSTemplate, INMSString
    {
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

        public NMSString0x20(string str)
        {
            this.Value = str;
        }

        public NMSString0x20() { }

		public static implicit operator NMSString0x20 ( string str ) => new NMSString0x20(str);
		public static implicit operator string ( NMSString0x20 str ) => str.Value;
	}
}
