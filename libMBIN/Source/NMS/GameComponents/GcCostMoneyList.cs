using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x585D80053DBA4C9C, NameHash = 0x22A3BF55F268EEBE)]
    public class GcCostMoneyList : NMSTemplate
    {
        public List<int> Costs;
        public GcCurrency CostCurrency;
        public bool AssertIfOutOfBounds;
        public enum OutOfBoundsBehaviourEnum { NoCost, UseFirst, UseLast }
        public OutOfBoundsBehaviourEnum OutOfBoundsBehaviour;
        public enum IndexProviderEnum { None, ShipSlot, ShipClass, DailyFreighters, WeaponClass, WeaponSlot, PetSlot }
        public IndexProviderEnum IndexProvider;
    }
}
