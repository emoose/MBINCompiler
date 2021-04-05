using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x0, NameHash = 0x962B9528105322C8)]
    public class GcRewardActivateFiends : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string SpawnID;
    }
}
