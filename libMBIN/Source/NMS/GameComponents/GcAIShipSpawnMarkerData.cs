using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x103B4E1E1547DE0E, NameHash = 0xDB40771B3EB38336)]
    public class GcAIShipSpawnMarkerData : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource MarkerIcon;
        /* 0x88 */ public NMSString0x20A MarkerLabel;
        /* 0xA8 */ public bool HideDuringCombat;
        /* 0xAC */ public float MinVisibleRange;
        /* 0xB0 */ public float MaxVisibleRange;
        /* 0xB4 */ public float MinAngleVisible;
        // size: 0x3
        public enum ShipsToMarkEnum : uint {
            None,
            Leader,
            All,
        }
        /* 0xB8 */ public ShipsToMarkEnum ShipsToMark;
    }
}
