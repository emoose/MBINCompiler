namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEDA8CB93C1DCF6D, NameHash = 0xBCA190142B227B20)]
    public class GcFreighterRoomNPCData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RoomID;
        // size: 0x5
        public enum SpawnCapacityEnum {
            SquadronPilot,
            FrigateCaptain,
            WorkerBio,
            WorkerTech,
            WorkerIndustry
        }
        [NMS(Size = 0x5, EnumType = typeof(SpawnCapacityEnum))]
        /* 0x10 */ public float[] SpawnCapacity;
        // size: 0x5
        public enum POISelectionWeightEnum {
            SquadronPilot,
            FrigateCaptain,
            WorkerBio,
            WorkerTech,
            WorkerIndustry
        }
        [NMS(Size = 0x5, EnumType = typeof(POISelectionWeightEnum))]
        /* 0x24 */ public float[] POISelectionWeight;
    }
}
