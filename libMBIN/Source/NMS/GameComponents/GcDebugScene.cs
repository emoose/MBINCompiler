using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1D00, GUID = 0x188140228BFE195A, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        /* 0x0000 */ public bool Active;
        /* 0x0001 */ public bool DebugDraw;
        /* 0x0002 */ public bool AutoSave;
        /* 0x0008 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        /* 0x0018 */ public bool FlyCamSmooth;
        /* 0x001C */ public float FlyCamSmoothFactor;
        /* 0x0020 */ public float FlyCamSpeedModifier;
        /* 0x0024 */ public float NPCIdleMinDelay;
        /* 0x0028 */ public float NPCIdleMaxDelay;
        /* 0x0030 */ public List<NMSString0x10> DefaultNPCIdles;
        /* 0x0040 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x0050 */ public bool LoadPetsFromDebugScene;
        /* 0x0051 */ public bool UpdatePetMoods;
        /* 0x0052 */ public bool ResetMoodsOnSummon;
        /* 0x0053 */ public bool ShowAccessoryMoods;
        /* 0x0054 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Size = 0x6)]
        /* 0x0058 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x0D18 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        /* 0x1348 */ public bool ForcePlayerWalk;
        /* 0x134C */ public int PetRideIndex;
        /* 0x1350 */ public List<Vector3f> PetRideWayPoints;
        /* 0x1360 */ public bool ForceSunPosition;
        /* 0x1370 */ public Vector3f ForcedSunPosition;
        /* 0x1380 */ public bool ControlClouds;
        /* 0x1384 */ public float CloudCover;
        /* 0x1388 */ public float CloudAnimScale;
        /* 0x138C */ public Vector2f CloudWindOffset;
        /* 0x1394 */ public Vector2f CloudStratosphereWindOffset;
        /* 0x13A0 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x13B0 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x13C0 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x13D0 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x13E0 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x13F0 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1400 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x1B00 */ public bool DebugDroneScanPlayer;
        /* 0x1B10 */ public Vector3f DebugDroneSpawn;
        /* 0x1B20 */ public Vector3f DebugDroneTarget;
        /* 0x1B30 */ public int DebugNumDrones;
        /* 0x1B40 */ public Vector3f DebugWalkerSpawn;
        /* 0x1B50 */ public Vector3f DebugWalkerTarget;
        /* 0x1B60 */ public Vector3f DebugFlybyTarget;
        /* 0x1B70 */ public Vector3f DebugFlybyDir;
        /* 0x1B80 */ public float DebugFlybyRange;
        /* 0x1B88 */ public GcSeed DebugFlybySeed;
        /* 0x1B98 */ public NMSString0x10 DebugExperienceCamShake;
        /* 0x1BB0 */ public Vector3f DebugShipSpawnPos;
        /* 0x1BC0 */ public Vector3f DebugShipSpawnFacing;
        /* 0x1BD0 */ public Vector3f DebugShipSpawnUp;
        /* 0x1BE0 */ public NMSString0x10 PulseEncounter;
        /* 0x1BF0 */ public Vector3f SandwormSpawnPos;
        /* 0x1C00 */ public Vector3f DebugFrigateFlybySpawnPos;
        /* 0x1C10 */ public float DebugFrigateFlybyRotation;
        /* 0x1C14 */ public float DebugFrigateFlybyHeightOffset;
        /* 0x1C18 */ public NMSString0x10 NormandyReward;
        /* 0x1C28 */ public float CameraSpinTime;
        /* 0x1C2C */ public float CameraSpinRevolutions;
        /* 0x1C30 */ public float CameraSpinVerticalOffset;
        /* 0x1C34 */ public float CameraSpinDistanceOffset;
        /* 0x1C38 */ public TkCurveType CameraSpinEasing;
        [NMS(Size = 0x6)]
        /* 0x1C40 */ public GcDebugPlanetPos[] PlanetPositions;
    }
}
