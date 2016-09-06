namespace MBINCompiler.Models.Structs
{
    public class GcShipHUDTargetData : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: __int64 __fastcall sub_14014C2E0(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        // line:   __int64 result; // rax@1
        // line:   v1 = a1;
        public GcShipHUDTargetIconData Template0;     // offset: 0, sz: 768, origin: sub_14014BC70((char *)a1);, comment: call sub        // line:   sub_14014BC70((char *)a1);
        [NMS(Size = 0x80)]
        public string Unknown300;     // offset: 768, sz: 128, origin:  "TEXTURES\\UI\\HUD\\ARROW.DDS"        // line:   strncpy((char *)(v1 + 768), "TEXTURES\\UI\\HUD\\ARROW.DDS", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 895) = 0;
        public float Unknown380;     // offset: 896, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 896) = 1067030938;
        public float Unknown384;     // offset: 900, sz: 4, origin: 1107296256, parsed: 32        // line:   *(_DWORD *)(v1 + 900) = 1107296256;
        public float Unknown388;     // offset: 904, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 904) = 1128792064;
        public float Unknown38C;     // offset: 908, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 908) = 1065353216;
        public float Unknown390;     // offset: 912, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 912) = 1065353216;
        public float Unknown394;     // offset: 916, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 916) = 1065353216;
        public float Unknown398;     // offset: 920, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 920) = 1065353216;
        public float Unknown39C;     // offset: 924, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 924) = 1065353216;
        public float Unknown3A0;     // offset: 928, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 928) = 1101004800;
        public float Unknown3A4;     // offset: 932, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(v1 + 932) = 1123024896;

        // missing 8 bytes at offset 932
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding3A8;        // offset: 936, sz: 8, comment: auto padding 

        public float Unknown3B0;     // offset: 944, sz: 4, origin: 1047904911, parsed: 0.24        // line:   *(_DWORD *)(v1 + 944) = 1047904911;
        public float Unknown3B4;     // offset: 948, sz: 4, origin: 1059145646, parsed: 0.63        // line:   *(_DWORD *)(v1 + 948) = 1059145646;
        public float Unknown3B8;     // offset: 952, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 952) = 1065353216;
        public float Unknown3BC;     // offset: 956, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 956) = 1065353216;
        public float Unknown3C0;     // offset: 960, sz: 4, origin: 1157234688, parsed: 2000        // line:   *(_DWORD *)(v1 + 960) = 1157234688;
        public float Unknown3C4;     // offset: 964, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 964) = 1065353216;
        public float Unknown3C8;     // offset: 968, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 968) = 1065353216;
        public float Unknown3CC;     // offset: 972, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 972) = 1084227584;
        public float Unknown3D0;     // offset: 976, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 976) = 1045220557;
        public float Unknown3D4;     // offset: 980, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 980) = 1036831949;
        public float Unknown3D8;     // offset: 984, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 984) = 1056964608;

        // missing 4 bytes at offset 984
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding3DC;        // offset: 988, sz: 4, comment: auto padding 

        public float Unknown3E0;     // offset: 992, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 992) = 1065353216;
        public float Unknown3E4;     // offset: 996, sz: 4, origin: 1038039908i64, parsed: 0.109, comment: two packed floats in a QWORD?(1)
        public float Unknown3E8;     // offset: 1000, sz: 4, origin: 1038039908i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 996) = 1038039908i64;
        public float Unknown3EC;     // offset: 1004, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1004) = 1065353216;
        public float Unknown3F0;     // offset: 1008, sz: 4, origin: 1119092736, parsed: 90        // line:   *(_DWORD *)(v1 + 1008) = 1119092736;

        // missing 12 bytes at offset 1008
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding3F4;        // offset: 1012, sz: 12, comment: auto padding 

        public float Unknown400;     // offset: 1024, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1024) = 0;  
        public float Unknown404;     // offset: 1028, sz: 4, origin: 1038039908, parsed: 0.109        // line:   *(_DWORD *)(v1 + 1028) = 1038039908;
        public float Unknown408;     // offset: 1032, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1032) = 1065353216;
        public float Unknown40C;     // offset: 1036, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1036) = 1065353216;
        // line:   result = 0i64;
        public float Unknown410;     // offset: 1040, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1040) = 1065353216;
        public float Unknown414;     // offset: 1044, sz: 4, origin: 1038039908i64, parsed: 0.109, comment: two packed floats in a QWORD?(1)
        public float Unknown418;     // offset: 1048, sz: 4, origin: 1038039908i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1044) = 1038039908i64;
        public float Unknown41C;     // offset: 1052, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1052) = 1065353216;
        public float Unknown420;     // offset: 1056, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1056) = 1065353216;
        public float Unknown424;     // offset: 1060, sz: 4, origin: 1057115603i64, parsed: 0.509, comment: two packed floats in a QWORD?(1)
        public float Unknown428;     // offset: 1064, sz: 4, origin: 1057115603i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1060) = 1057115603i64;
        public float Unknown42C;     // offset: 1068, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1068) = 1065353216;
        // line:   return result;
        // line: }
    }
}
