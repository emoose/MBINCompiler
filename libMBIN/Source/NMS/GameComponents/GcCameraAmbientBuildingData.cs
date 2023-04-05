using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E71DBE268F475D3, NameHash = 0xDF9F37F8504FFE4D)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        /* 0x20 */ public float Offset;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        [NMS(Size = 0x36, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x26 */ public bool[] AvailableBuildings;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x5C */ public bool[] AvailableRaces;
    }
}
