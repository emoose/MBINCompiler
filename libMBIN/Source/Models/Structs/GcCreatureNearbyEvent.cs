namespace libMBIN.Models.Structs
{
    public class GcCreatureNearbyEvent : NMSTemplate      // size: 0x18
    {
        // I don't really know... *maybe* creature alert data and an inverse bool?
        public GcCreatureAlertData AlertTable;
        public bool Inverse;
    }
}
