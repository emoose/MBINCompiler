namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC030AA469952A455, NameHash = 0xA12C289C)]
    public class TkCavesEnum : NMSTemplate
    {
        // size: 0x1
        public enum CaveTypesEnum : uint {
            Underground,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CaveTypesEnum CaveTypes;
    }
}
