using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38F8, GUID = 0x16AF75AD89EF15F2)]
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x0000 */ public bool InvertLookControls;
        /* 0x0001 */ public bool InvertFlightControls;
        /* 0x0002 */ public bool HUDHidden;
        /* 0x0003 */ public bool Vibration;
        /* 0x0004 */ public int ScreenBrightness;
        /* 0x0008 */ public int MusicVolume;
        /* 0x000C */ public int SfxVolume;
        /* 0x0010 */ public int LookSensitivityV2;
        /* 0x0014 */ public int FlightSensitivityV2;
        /* 0x0018 */ public int MouseSpringSmoothing;
        /* 0x001C */ public GcBlockListPersistence BlockList;
        /* 0x386C */ public int MotionBlurAmount;
        /* 0x3870 */ public int Filter;
        /* 0x3874 */ public bool DamageNumbers;
        public enum PS4FixedFPSEnum { Invalid, False, True}
        /* 0x3878 */ public PS4FixedFPSEnum PS4FixedFPS;
        /* 0x387C */ public float PS4FOVFoot;
        /* 0x3880 */ public float PS4FOVShip;
        /* 0x3884 */ public bool XboxOneXHighResolutionMode;
        public enum BaseSharingModeEnum { Undecided, On, Off }
		/* 0x3888 */ public BaseSharingModeEnum BaseSharingMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x388C */ public byte[] Padding380C;
        /* 0x3890 */ public List<NMSString0x10> SeenSubstances;
        /* 0x38A0 */ public List<NMSString0x10> SeenTechnologies;
        /* 0x38B0 */ public List<NMSString0x10> SeenProducts;
        /* 0x38C0 */ public List<NMSString0x20> SeenWikiTopics;
        /* 0x38D0 */ public List<NMSString0x20> UnlockedWikiTopics;
        /* 0x38E0 */ public bool SeenOthers;
        /* 0x38E1 */ public bool NetworkPlay;
        /* 0x38E2 */ public bool VoiceChat;
        /* 0x38E3 */ public bool AmbientMultiplayer;
        public enum TemperatureUnitEnum { Invalid, C, F, K }
        /* 0x38E4 */ public TemperatureUnitEnum TemperatureUnit;
        /* 0x38E8 */ public bool UseOldMouseFlight;
        /* 0x38EC */ public int LastSeenCommunityMission;
        /* 0x38F0 */ public int LastSeenCommunityMissionTier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x38F4 */ public byte[] EndPadding;
    }
}
