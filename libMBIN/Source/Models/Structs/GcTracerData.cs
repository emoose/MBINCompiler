namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x633DCF0906D3DEBD)]
    public class GcTracerData : NMSTemplate
    {
        public float Length;                // 41A00000h
        public float Speed;                 // 43FA0000h
        public float DamageMinDistance;     // 41200000h
        public float DamageMaxDistance;     // 42C80000h
        public float DamageMin;             // 3F800000h
        public float DamageMax;             // 3F800000h
    }
}
