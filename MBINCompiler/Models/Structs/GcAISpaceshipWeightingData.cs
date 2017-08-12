namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Size = 0x7)]
        public float[] CivilianClassWeightings;

        /*
        rax, 3F8000003F800000h
        mov     r8d, 3Fh        ; Count
        mov[rdi], rax
        mov[rdi + 8], rax
        mov[rdi + 10h], rax
        mov[rdi + 18h], eax*/
    }
}
