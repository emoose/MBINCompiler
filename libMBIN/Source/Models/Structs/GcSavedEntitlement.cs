namespace MBINCompiler.Models.Structs
{
    public class GcSavedEntitlement : NMSTemplate // 0x100 bytes
    {
        [NMS(Size = 0x100)]
        public string EntitlementId;
    }
}
