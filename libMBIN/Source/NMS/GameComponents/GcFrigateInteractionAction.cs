namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61DF172F7A9D8DB4, NameHash = 0xD1183794AF82FF99)]
    public class GcFrigateInteractionAction : NMSTemplate
    {
        // size: 0x3
        public enum ActionTypeEnum {
            Repair,
            UpdateDamagedComponents,
            CargoPhoneCall,
        }
        /* 0x0 */ public ActionTypeEnum ActionType;
        /* 0x8 */ public NMSString0x20A CommunicatorDialog;
    }
}
