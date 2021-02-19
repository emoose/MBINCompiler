using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1490, GUID = 0x3E2EDA5C6D5B665F, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        /* 0x0000 */ public bool Active;
        /* 0x0001 */ public bool DebugDraw;
        /* 0x0002 */ public bool AutoSave;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x0003 */ public byte[] Padding3;
        /* 0x0008 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        /* 0x0018 */ public bool FlyCamSmooth;
        /* 0x001C */ public float FlyCamSmoothFactor;
        /* 0x0020 */ public float FlyCamSpeedModifier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0024 */ public byte[] Padding24;
        /* 0x0028 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x0038 */ public bool LoadPetsFromDebugScene;
        /* 0x0039 */ public bool UpdatePetMoods;
        /* 0x003A */ public bool ResetMoodsOnSummon;
        /* 0x003B */ public bool ShowAccessoryMoods;
        /* 0x003C */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Size = 0x6)]
        /* 0x0040 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x05E0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        /* 0x0C10 */ public bool ForcePlayerWalk;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0C11 */ public byte[] PaddingC11;
        /* 0x0C18 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x0C28 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x0C38 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x0C48 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x0C58 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x0C68 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x0C78 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x1378 */ public bool DebugDroneScanPlayer;
        /* 0x1380 */ public Vector3f DebugDroneSpawn;
        /* 0x1390 */ public Vector3f DebugDronTarget;
        /* 0x13A0 */ public int DebugNumDrones;
        /* 0x13B0 */ public Vector3f DebugWalkerSpawn;
        /* 0x13C0 */ public Vector3f DebugWalkerTarget;
        /* 0x13D0 */ public Vector3f DebugFlybyTarget;
        /* 0x13E0 */ public Vector3f DebugFlybyDir;
        /* 0x13F0 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x13F4 */ public byte[] Padding13F4;
        /* 0x13F8 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x1408 */ public string DebugExperienceCamShake;
        /* 0x1420 */ public Vector3f DebugShipSpawnPos;
        /* 0x1430 */ public Vector3f DebugShipSpawnFacing;
        /* 0x1440 */ public Vector3f DebugShipSpawnUp;
        [NMS(Size = 0x10)]
        /* 0x1450 */ public string PulseEncounter;
        /* 0x1460 */ public Vector3f SandwormSpawnPos;
        /* 0x1470 */ public float CameraSpinTime;
        /* 0x1474 */ public float CameraSpinRevolutions;
        /* 0x1478 */ public float CameraSpinVerticalOffset;
        /* 0x147C */ public float CameraSpinDistanceOffset;
        /* 0x1480 */ public TkCurveType CameraSpinEasing;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1484 */ public byte[] EndPadding;
    }
}
