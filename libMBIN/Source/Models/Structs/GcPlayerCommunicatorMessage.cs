namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x50, GUID = 0x0C0B64BD7B895172A)]
    public class GcPlayerCommunicatorMessage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Dialog;
        /* 0x20 */ public bool ShowHologram;
		public enum CommunicatorTypeEnum { HoloExplorer, HoloSceptic, HoloNoone, Generic, PlayerFreighterCaptain, Polo, Nada }
		public CommunicatorTypeEnum CommunicatorType;
        /* 0x28 */ public GcAlienRace RaceOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string ShipHUDOverride;
    }
}
