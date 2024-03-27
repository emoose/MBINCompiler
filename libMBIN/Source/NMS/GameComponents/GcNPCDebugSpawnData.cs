using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1A0E2DE6B0623BB, NameHash = 0x1D427C136EB50E9D)]
    public class GcNPCDebugSpawnData : NMSTemplate
    {
        /* 0x000 */ public Vector3f Position;
        /* 0x010 */ public Vector3f Facing;
        /* 0x020 */ public Vector3f Up;
        /* 0x030 */ public bool FollowWaypoints;
        /* 0x034 */ public float InitialDelay;
        /* 0x038 */ public List<Vector3f> Waypoints;
        /* 0x048 */ public bool PlayIdles;
        /* 0x050 */ public List<NMSString0x10> Idles;
        /* 0x060 */ public bool Run;
        /* 0x061 */ public bool RidePet;
        /* 0x064 */ public GcAlienRace Race;
        /* 0x068 */ public GcSeed Seed;
        /* 0x078 */ public bool AddPetAccessories;
        /* 0x07C */ public float PetFollowOffset;
        /* 0x080 */ public GcPetData Pet;
        /* 0x2A0 */ public GcPetCustomisationData PetAccessoryCustomisation;
    }
}
