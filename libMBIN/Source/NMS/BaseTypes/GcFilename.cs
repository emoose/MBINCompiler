using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x1)]
    public class GcFilename : NMSTemplate, INMSVariableLengthString
    {
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public string String {
            get => StringValue();
            set => Value = value;
        }

        /// <summary>
        /// Returns the value held by this string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Value;
        }

        public GcFilename(string str)
        {
            this.Value = str;
        }

        public GcFilename() { }

        public static implicit operator GcFilename ( string str ) => new GcFilename { Value = str };
        public static implicit operator string ( GcFilename str ) => str.Value;
    }
}
