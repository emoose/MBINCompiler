namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFF0075CCC1E02339, NameHash = 0x359F7497)]
    public class TkFloatRange : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Maximum;
        [NMS(Index = 0)]
        /* 0x4 */ public float Minimum;
    }
}
