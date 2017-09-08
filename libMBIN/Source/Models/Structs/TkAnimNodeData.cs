using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace libMBIN.Models.Structs
{
    public class TkAnimNodeData : NMSTemplate       // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string Node;

        public bool CanCompress; // set to 0xFE, with following 3 padding bytes also set to 0xFE, might be padding indicating that this is 0? currently treated as 1...
        public int RotIndex;
        public int TransIndex;
        public int ScaleIndex;

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            if (field == null || fieldInfo == null)
                return false;

            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(CanCompress):
                    //writer.Align(4, 0);
                    writer.Write(0xFEFEFEFE);
                    return true;

            }

            return false;
        }
    }
}
