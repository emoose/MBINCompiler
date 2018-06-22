namespace libMBIN.Models.Structs
{
    public class GcCreatureNearbyEvent : NMSTemplate      // size: 0x18
    {
        public GcCreatureAlertData AlertTable;
        public bool Inverse;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
