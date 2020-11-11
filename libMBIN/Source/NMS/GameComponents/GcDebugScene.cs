using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C0, GUID = 0xCB3E2B6AC56EA79D, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        /* 0x000 */ public bool Active;
        /* 0x001 */ public bool DebugDraw;
        /* 0x002 */ public bool AutoSave;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x003 */ public byte[] Padding3;
        /* 0x008 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        /* 0x018 */ public bool FlyCamSmooth;
        /* 0x01C */ public float FlyCamSmoothFactor;
        /* 0x020 */ public float FlyCamSpeedModifier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x024 */ public byte[] Padding24;
        /* 0x028 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x038 */ public bool ForcePlayerWalk;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x039 */ public byte[] Padding39;
        /* 0x040 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x050 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x060 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x070 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x080 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x090 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x0A0 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x7A0 */ public bool DebugDroneScanPlayer;
        /* 0x7B0 */ public Vector3f DebugDroneSpawn;
        /* 0x7C0 */ public Vector3f DebugDronTarget;
        /* 0x7D0 */ public int DebugNumDrones;
        /* 0x7E0 */ public Vector3f DebugWalkerSpawn;
        /* 0x7F0 */ public Vector3f DebugWalkerTarget;
        /* 0x800 */ public Vector3f DebugFlybyTarget;
        /* 0x810 */ public Vector3f DebugFlybyDir;
        /* 0x820 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x824 */ public byte[] Padding824;
        /* 0x828 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x838 */ public string DebugExperienceCamShake;
        /* 0x850 */ public Vector3f DebugShipSpawnPos;
        /* 0x860 */ public Vector3f DebugShipSpawnFacing;
        /* 0x870 */ public Vector3f DebugShipSpawnUp;
        [NMS(Size = 0x10)]
        /* 0x880 */ public string PulseEncounter;
        /* 0x890 */ public Vector3f SandwormSpawnPos;
        /* 0x8A0 */ public float CameraSpinTime;
        /* 0x8A4 */ public float CameraSpinRevolutions;
        /* 0x8A8 */ public float CameraSpinVerticalOffset;
        /* 0x8AC */ public float CameraSpinDistanceOffset;
        /* 0x8B0 */ public TkCurveType CameraSpinEasing;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x8B4 */ public byte[] EndPadding;
    }
}
