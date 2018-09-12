using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0x0AF8C623DBEFEC570)]
    public class GcScanData : NMSTemplate
    {
		public enum ScanTypeEnum { Tool, Beacon, RadioTower, Observatory, DistressSignal, Waypoint, Ship, DebugPlanet, DebugSpace, VisualOnly }
		public ScanTypeEnum ScanType;
	  /* 0x004 */ public float PulseRange;          // 41200000h
	  /* 0x008 */ public float PulseTime;           // 41200000h
	  /* 0x00C */ public bool PlayAudioOnMarkers;   // 1
	  /* 0x010 */ public float ChargeTime;          // 40800000h
    }
}
