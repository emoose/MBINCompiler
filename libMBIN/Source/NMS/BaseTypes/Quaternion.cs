using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    public class Quaternion : NMSTemplate
    {
        public double X;
        public double Y;
        public double Z;
        public double W;
        public int dropComponent;

        public Quaternion(double x, double y, double z, double w, int dropComponent)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
            this.dropComponent = dropComponent;
        }

        public Quaternion() { }

        /// <summary>
        /// Returns a formatted string for this quaternion.
        /// <br/>Format: (x, y, z, w)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({this.X}, {this.Y}, {this.Z}, {this.W})";
        }

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
            {
            if (field == null || fieldInfo == null)
                return false;

            switch (fieldInfo.Name)
                {
                case nameof(dropComponent):
                    // Do nothing...
                    return true;
            }

            return false;
        }
    }
}
