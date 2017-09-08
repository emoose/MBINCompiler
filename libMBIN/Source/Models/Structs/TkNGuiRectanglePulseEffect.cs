namespace libMBIN.Models.Structs
{
    public class TkNGuiRectanglePulseEffect : NMSTemplate       // size: 0x14
    {
        public float PulseWidth;                // 40C00000h
        public float PulseOffset;               // 42200000h
        public float PulseRate;                 // 3F99999Ah
        public TkCurveType PulseAlphaCurve;
        public TkCurveType PulseSizeCurve;
    }
}
