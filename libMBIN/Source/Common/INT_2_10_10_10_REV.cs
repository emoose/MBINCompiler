using System;

namespace libMBIN
{
    public struct INT_2_10_10_10_REV
    {
        private const int sel = 0b1111111111;
        public float[] vals;

        public static float[] FromBytes(int verts)
        {
            float[] output = new float[4];
            for (int i = 0; i < 3; i++)
                output[i] = twos_complement((verts & (sel << i * 10)) >> i * 10, 10);
            output[3] = (verts & (sel << 30)) >> 30;
            float norm = (float)Math.Sqrt(output[0] * output[0] + output[1] * output[1] + output[2] * output[2]);
            for (int i = 0; i < 3; i++)
                output[i] = output[i] / norm;
            return output;
        }

        public static int FromVerts(float[] verts)
        {
            int output = 0;
            int[] newverts = new int[4] { 0, 0, 0, 1 };
            for (int i=0; i < 3; i++)
            {
                int temp = (int)(511 * verts[i]);   // rounds down
                if (Math.Sign(temp) == +1)
                    newverts[i] = temp;
                else
                    newverts[i] = (Math.Abs(temp) ^ sel) + 1;
            }

            for (int i = 0; i < 4; i++)
                output = output | (newverts[i] << i * 10);
            return output;
        }

        private static int twos_complement(int input_value, int num_bits)
        {
            int mask = (int)Math.Pow(2, (num_bits - 1));
            return -(input_value & mask) + (input_value & ~mask);
        }

        public INT_2_10_10_10_REV(float[] vals)
        {
            this.vals = vals;
        }

        public INT_2_10_10_10_REV(float val0, float val1, float val2, float val3)
        {
            this.vals = new float[] { val0, val1, val2, val3 };
        }

        public override string ToString()
        {
            return $"{{{vals[0]}, {vals[1]}, {vals[2]}, {vals[3]}}}";
        }

        public static explicit operator INT_2_10_10_10_REV(float[] vals)
        {
            return new INT_2_10_10_10_REV(vals);
        }

        public static implicit operator float[] (INT_2_10_10_10_REV val)
        {
            return val.vals;
        }
    }
}