using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC24B0FCC0C5043F, NameHash = 0x85E81CB9)]
    public class GcFreighterRoomNPCData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RoomID;
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x10 */ public float[] POISelectionWeight;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x24 */ public float[] SpawnCapacity;
    }
}
