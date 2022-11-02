namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF62414AACC4BE6A3, NameHash = 0xCABBB7951E50DCAF)]
    public class TkJointBindingData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public float[] InvBindMatrix;
        [NMS(Size = 0x3)]
        /* 0x40 */ public float[] BindTranslate;
        [NMS(Size = 0x4)]
        /* 0x4C */ public float[] BindRotate;
        [NMS(Size = 0x3)]
        /* 0x5C */ public float[] BindScale;
    }
}
