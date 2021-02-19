using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x260, GUID = 0x4CEC5B9A160BCA49, NameHash = 0x1D427C136EB50E9D)]
    public class GcNPCDebugSpawnData : NMSTemplate
    {
        /* 0x000 */ public Vector3f Position;
        /* 0x010 */ public Vector3f Facing;
        /* 0x020 */ public Vector3f up;
        /* 0x030 */ public bool FollowWaypoints;
        /* 0x034 */ public float InitialDelay;
        /* 0x038 */ public List<Vector4f> Waypoints;
        /* 0x048 */ public bool Run;
        /* 0x04C */ public GcAlienRace Race;
        /* 0x050 */ public GcSeed Seed;
        /* 0x060 */ public bool AddPetAccessories;
        /* 0x064 */ public float PetFollowOffset;
        /* 0x068 */ public GcPetData Pet;
        /* 0x158 */ public GcPetCustomisationData PetAccessoryCustomisation;
    }
}
