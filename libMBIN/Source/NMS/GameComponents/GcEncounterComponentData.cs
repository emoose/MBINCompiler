using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x1CBAA2AF7483FD9F, NameHash = 0x1BAD68301EABDA5C)]
    public class GcEncounterComponentData : NMSTemplate
    {
        public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards, ScrapHeap, CorruptedDroneReward, CorruptedDroneInteract, GroundWorms }
        public EncounterTypeEnum EncounterType;
        public List<NMSString0x10> InteractMissionTable;
    }
}