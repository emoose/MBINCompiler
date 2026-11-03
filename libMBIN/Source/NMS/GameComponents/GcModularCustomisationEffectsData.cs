namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD24C54A53B9158A, NameHash = 0xF325F5BB)]
    public class GcModularCustomisationEffectsData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float EffectTime;
        // size: 0x3
        public enum ModularCustomisationEffectModeEnum : uint {
            Build,
            BuildOutward,
            Dissolve,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public ModularCustomisationEffectModeEnum ModularCustomisationEffectMode;
    }
}
