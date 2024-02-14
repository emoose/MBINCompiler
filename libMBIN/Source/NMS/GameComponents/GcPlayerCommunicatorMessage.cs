using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9766DD03F729F7CF, NameHash = 0xF839343C27983F1A)]
    public class GcPlayerCommunicatorMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Dialog;
        /* 0x20 */ public bool ShowHologram;
        // size: 0xB
        public enum CommunicatorTypeEnum : uint {
            HoloExplorer,
            HoloSceptic,
            HoloNoone,
            Generic,
            PlayerFreighterCaptain,
            Polo,
            Nada,
            QuicksilverBot,
            PlayerSettlementResident,
            CargoScanDrone,
            Tethys,
        }
        /* 0x24 */ public CommunicatorTypeEnum CommunicatorType;
        /* 0x28 */ public GcAlienRace RaceOverride;
        /* 0x30 */ public NMSString0x20A ShipHUDOverride;
        /* 0x50 */ public GcAudioWwiseEvents HailAudioOverride;
    }
}
