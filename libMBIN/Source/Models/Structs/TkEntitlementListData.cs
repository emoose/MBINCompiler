namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x50, GUID = 0x18203ECAB461D679)]
    public class TkEntitlementListData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string EntitlementId;
        [NMS(Size = 0x40)]
        public string ServicesID;
    }
}
