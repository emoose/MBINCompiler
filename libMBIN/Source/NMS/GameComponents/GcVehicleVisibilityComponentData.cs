namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16749B20280CB79C, NameHash = 0x983D2776)]
    public class GcVehicleVisibilityComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float EffectFalloffRadius;
        [NMS(Index = 1)]
        /* 0x4 */ public float Radius;
        [NMS(Index = 0)]
        /* 0x8 */ public bool OnlyInSeasonalUA;
        // size: 0x1
        public enum VehicleVisibilityRuleEnum : byte {
            Privilege_CargoObjectsOnTruck,
        }
        [NMS(Index = 3)]
        /* 0x9 */ public VehicleVisibilityRuleEnum VehicleVisibilityRule;
    }
}
