namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87530C1BFD8FE323, NameHash = 0x79F70E3905C45C6D)]
    public class GcObjectPlacementCategory : NMSTemplate
    {
        // size: 0x5
        public enum ObjectPlacementEnum {
            None,
            ResourceSmall,
            ResourceMedium,
            ResourceLarge,
            ResourceDebris
        }
        /* 0x0 */ public ObjectPlacementEnum ObjectPlacement;
    }
}
