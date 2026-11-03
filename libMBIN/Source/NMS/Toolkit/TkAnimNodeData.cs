namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x96DAE369FA4D052E, NameHash = 0x6724EB30)]
    public class TkAnimNodeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Node;
        [NMS(Index = 1)]
        /* 0x10 */ public int RotIndex;
        [NMS(Index = 3)]
        /* 0x14 */ public int ScaleIndex;
        [NMS(Index = 2)]
        /* 0x18 */ public int TransIndex;
    }
}
