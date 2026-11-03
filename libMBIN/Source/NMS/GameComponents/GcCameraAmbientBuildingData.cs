using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD06D34D8E9E3A528, NameHash = 0x29E8EF9E)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        [NMS(Index = 2)]
        /* 0x20 */ public float Offset;
        [NMS(Index = 5, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x24 */ public bool[] AvailableBuildings;
        [NMS(Index = 6, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x63 */ public bool[] AvailableRaces;
        [NMS(Index = 4)]
        /* 0x6C */ public bool AvoidTerrain;
        [NMS(Index = 3)]
        /* 0x6D */ public bool UseLookAt;
    }
}
