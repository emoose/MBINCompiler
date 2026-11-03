using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B332BAEC89E72BA, NameHash = 0xE70A1802)]
    public class GcPetBattlerMoveSet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public GcPetBattlerMoveSlotOptions Slot1;
        [NMS(Index = 2)]
        /* 0x20 */ public GcPetBattlerMoveSlotOptions Slot2;
        [NMS(Index = 3)]
        /* 0x30 */ public GcPetBattlerMoveSlotOptions Slot3;
        [NMS(Index = 4)]
        /* 0x40 */ public GcPetBattlerMoveSlotOptions Slot4;
        [NMS(Index = 5)]
        /* 0x50 */ public GcPetBattlerMoveSlotOptions Slot5;
    }
}
