using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class TkAnimNodeFrameData : NMSTemplate
    {
        public List<short> Rotations;       //dummy
        public List<Vector4f> Translations;
        public List<Vector4f> Scales;

        /*
        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            Dictionary<int, int> TypeMap = new Dictionary<int, int> { { 5131, 8 }, { 36255, 4 }, { 5121, 4 } };

            switch (fieldName)
            {
                case nameof(Rotations):
                    return 1;
            }
            return null;
        }*/
    }
}

/*
def read_as_comp_q_4(val):
    v = 0
    for i in range(6):
        v |= val[i] << 8*(5-i)
        #v |= val[i] << 8*i
    
    print("start value", v, hex(v))
    v1 = (v >> 32) & 0xFFFF
    v2 = (v >> 16) & 0xFFFF
    v3 = (v >> 1) & 0x7FFF
    v4 = v & 0x1

    #scale = 1.0 / 1.4142
    scale = 1.0
    print("values", v1, v2, v3, v4)
    print("conv_values", ((float(v1) - 0x7FFF) / 0x7FFF), 
                         ((float(v2) - 0x7FFF) / 0x7FFF), 
                         ((float(v3) - 0x3FFF) / 0x3FFF))
*/