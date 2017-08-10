namespace MBINCompiler.Models.Structs
{
    public class TkShearWindData : NMSTemplate      // size: 0x80
    {
        [NMS(Size = 0x10)]
        public string Name;
        public float OverallWindStrength;
        public float LdsWindStrength;
        public float LdsWindSpeed;
        public float ShearWindSpeed;
        public float WindShearVertpushStrength;
        public float WindShearGradientStrength;
        public float WindShearToDotLdsFactor;
        public TkShearWindOctaveData Octave0;
        public TkShearWindOctaveData Octave1;
        public TkShearWindOctaveData Octave2;
        public TkShearWindOctaveData Octave3;

        public float Unknown;
        //[NMS(Size = 4, Ignore = true)]
        //public byte[] Padding7C;
    }
}
