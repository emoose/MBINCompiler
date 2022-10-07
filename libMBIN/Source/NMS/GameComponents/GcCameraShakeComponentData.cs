using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FC4FB96433D6E8D, NameHash = 0x77B3408A8150441E)]
    public class GcCameraShakeComponentData : NMSTemplate
    {
        /* 0x0 */ public float DangerRange;
        /* 0x8 */ public List<GcCameraShakeTriggerData> AnimTriggers;
    }
}
