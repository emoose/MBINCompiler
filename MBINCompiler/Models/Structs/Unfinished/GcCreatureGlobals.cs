namespace MBINCompiler.Models.Structs // 0x690
{
    public class GcCreatureGlobals : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: char *__fastcall sub_140139230(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        // line:   char *result; // rax@1
        // line:   v1 = a1;
        public bool Unknown0;     // offset: 0, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)a1 = 0;

        // missing 3 bytes at offset 0
        // does 0 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;        // offset: 1, sz: 3, comment: auto padding

        public float Unknown4;     // offset: 4, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 4) = 0; // adjust offset order!
        public float Unknown8;     // offset: 8, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float UnknownC;     // offset: 12, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 8) = 1065353216i64;
        public float Unknown10;     // offset: 16, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(a1 + 16) = 1028443341;
        public float Unknown14;     // offset: 20, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 20) = 1084227584;
        public float Unknown18;     // offset: 24, sz: 4, origin: 1094713344, parsed: 12        // line:   *(_DWORD *)(a1 + 24) = 1094713344;
        public float Unknown1C;     // offset: 28, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 28) = 1065353216;
        public float Unknown20;     // offset: 32, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 32) = 1065353216;
        public float Unknown24;     // offset: 36, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 36) = 1045220557;
        public float Unknown28;     // offset: 40, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(a1 + 40) = 1090519040;
        public float Unknown2C;     // offset: 44, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 44) = 1092616192;
        public float Unknown30;     // offset: 48, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 48) = 1120403456;
        public float Unknown34;     // offset: 52, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 52) = 1036831949;
        public float Unknown38;     // offset: 56, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 56) = 1036831949;
        public float Unknown3C;     // offset: 60, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 60) = 1065353216;
        public float Unknown40;     // offset: 64, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 64) = 1092616192;
        public float Unknown44;     // offset: 68, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 68) = 1036831949;
        public float Unknown48;     // offset: 72, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 72) = 1069547520;
        public float Unknown4C;     // offset: 76, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 76) = 1065353216;
        public float Unknown50;     // offset: 80, sz: 4, origin: 1051931443, parsed: 0.35        // line:   *(_DWORD *)(a1 + 80) = 1051931443;
        public float Unknown54;     // offset: 84, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 84) = 1075838976;
        public float Unknown58;     // offset: 88, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 88) = 1075838976;
        public float Unknown5C;     // offset: 92, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(a1 + 92) = 1063675494;
        public float Unknown60;     // offset: 96, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 96) = 1092616192;

        // missing 12 bytes at offset 96
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding64;        // offset: 100, sz: 12, comment: auto padding

        public GcCameraShakeData Template70;     // offset: 112, sz: 192, origin: sub_1401373A0((char *)(a1 + 112));, comment: call sub        // line:   sub_1401373A0((char *)(a1 + 112));
        public float Unknown130;     // offset: 304, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 304) = 1056964608;
        public float Unknown134;     // offset: 308, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 308) = 1065353216;
        public float Unknown138;     // offset: 312, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 312) = 1056964608;
        public float Unknown13C;     // offset: 316, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 316) = 1077936128;
        public float Unknown140;     // offset: 320, sz: 4, origin: 1145569280, parsed: 800        // line:   *(_DWORD *)(v1 + 320) = 1145569280;
        public float Unknown144;     // offset: 324, sz: 4, origin: 1143930880, parsed: 700        // line:   *(_DWORD *)(v1 + 324) = 1143930880;
        public float Unknown148;     // offset: 328, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 328) = 1084227584;
        public float Unknown14C;     // offset: 332, sz: 4, origin: 1147207680, parsed: 900        // line:   *(_DWORD *)(v1 + 332) = 1147207680;
        public float Unknown150;     // offset: 336, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 336) = 1084227584;
        public float Unknown154;     // offset: 340, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 340) = 1065353216;
        public float Unknown158;     // offset: 344, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 344) = 1109393408;
        public float Unknown15C;     // offset: 348, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 348) = 1092616192;
        public float Unknown160;     // offset: 352, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 352) = 1065353216;
        public float Unknown164;     // offset: 356, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 356) = 1065353216;
        public float Unknown168;     // offset: 360, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 360) = 0x40000000;
        public float Unknown16C;     // offset: 364, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 364) = 1056964608;
        public float Unknown170;     // offset: 368, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 368) = 1092616192;
        public float Unknown174;     // offset: 372, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 372) = 1077936128;
        public float Unknown178;     // offset: 376, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 376) = 1112014848;
        public float Unknown17C;     // offset: 380, sz: 4, origin: 1148846080, parsed: 1000        // line:   *(_DWORD *)(v1 + 380) = 1148846080;
        public float Unknown180;     // offset: 384, sz: 4, origin: 1084437299, parsed: 5.1        // line:   *(_DWORD *)(v1 + 384) = 1084437299;
        public float Unknown184;     // offset: 388, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 388) = 1065353216;
        public float Unknown188;     // offset: 392, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 392) = 1050253722;
        public float Unknown18C;     // offset: 396, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 396) = 1056964608;
        public float Unknown190;     // offset: 400, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 400) = 1050253722;
        public float Unknown194;     // offset: 404, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 404) = 1097859072;
        public float Unknown198;     // offset: 408, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 408) = 1101004800;
        public float Unknown19C;     // offset: 412, sz: 4, origin: 981668463, parsed: 0.001        // line:   *(_DWORD *)(v1 + 412) = 981668463;
        public float Unknown1A0;     // offset: 416, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 416) = 1061997773;
        public float Unknown1A4;     // offset: 420, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 420) = 1056964608;
        public float Unknown1A8;     // offset: 424, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 424) = 1112014848;
        public float Unknown1AC;     // offset: 428, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 428) = 1050253722;
        public float Unknown1B0;     // offset: 432, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 432) = 1092616192;
        public float Unknown1B4;     // offset: 436, sz: 4, origin: 1099956224, parsed: 18        // line:   *(_DWORD *)(v1 + 436) = 1099956224;
        public float Unknown1B8;     // offset: 440, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 440) = 0x40000000;
        public float Unknown1BC;     // offset: 444, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 444) = 1077936128;
        public float Unknown1C0;     // offset: 448, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 448) = 1090519040;
        public float Unknown1C4;     // offset: 452, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 452) = 0x40000000;
        public float Unknown1C8;     // offset: 456, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 456) = 1077936128;
        public float Unknown1CC;     // offset: 460, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 460) = 1120403456;
        public float Unknown1D0;     // offset: 464, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 464) = 1065353216;
        public float Unknown1D4;     // offset: 468, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 468) = 1084227584;
        public float Unknown1D8;     // offset: 472, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 472) = 1050253722;
        public float Unknown1DC;     // offset: 476, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 476) = 1112014848;
        public float Unknown1E0;     // offset: 480, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 480) = 1084227584;
        public float Unknown1E4;     // offset: 484, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 484) = 1065353216;
        public float Unknown1E8;     // offset: 488, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(v1 + 488) = 1075838976;
        public float Unknown1EC;     // offset: 492, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 492) = 1077936128;
        public float Unknown1F0;     // offset: 496, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 496) = 1106247680;
        public float Unknown1F4;     // offset: 500, sz: 4, origin: 1140457472, parsed: 500        // line:   *(_DWORD *)(v1 + 500) = 1140457472;
        public float Unknown1F8;     // offset: 504, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 504) = 1112014848;
        public float Unknown1FC;     // offset: 508, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 508) = 1036831949;
        public float Unknown200;     // offset: 512, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 512) = 1058642330;
        public float Unknown204;     // offset: 516, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 516) = 1097859072;
        public float Unknown208;     // offset: 520, sz: 4, origin: 1096810496, parsed: 14        // line:   *(_DWORD *)(v1 + 520) = 1096810496;
        public float Unknown20C;     // offset: 524, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 524) = 1120403456;
        public float Unknown210;     // offset: 528, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 528) = 1069547520;
        public float Unknown214;     // offset: 532, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 532) = 1077936128;
        public float Unknown218;     // offset: 536, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 536) = 1084227584;
        public float Unknown21C;     // offset: 540, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 540) = 1077936128;
        public float Unknown220;     // offset: 544, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 544) = 1090519040;
        public float Unknown224;     // offset: 548, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 548) = 1084227584;
        public float Unknown228;     // offset: 552, sz: 4, origin: 1097859072i64, parsed: 15, comment: two packed floats in a QWORD?(1)
        public float Unknown22C;     // offset: 556, sz: 4, origin: 1097859072i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 552) = 1097859072i64;
        public float Unknown230;     // offset: 560, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 560) = 0;
        public float Unknown234;     // offset: 564, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 564) = 1084227584;
        public float Unknown238;     // offset: 568, sz: 4, origin: 1086324736i64, parsed: 6, comment: two packed floats in a QWORD?(1)
        public float Unknown23C;     // offset: 572, sz: 4, origin: 1086324736i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 568) = 1086324736i64;
        public float Unknown240;     // offset: 576, sz: 4, origin: 1096810496i64, parsed: 14, comment: two packed floats in a QWORD?(1)
        public float Unknown244;     // offset: 580, sz: 4, origin: 1096810496i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 576) = 1096810496i64;
        public float Unknown248;     // offset: 584, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 584) = 0;
        public float Unknown24C;     // offset: 588, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 588) = 1120403456;
        public float Unknown250;     // offset: 592, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 592) = 1125515264;
        public float Unknown254;     // offset: 596, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 596) = 1114636288;
        public float Unknown258;     // offset: 600, sz: 4, origin: 1097859072i64, parsed: 15, comment: two packed floats in a QWORD?(1)
        public float Unknown25C;     // offset: 604, sz: 4, origin: 1097859072i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 600) = 1097859072i64;
        public float Unknown260;     // offset: 608, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 608) = 0;
        public float Unknown264;     // offset: 612, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 612) = 1120403456;
        public float Unknown268;     // offset: 616, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 616) = 1125515264;
        public float Unknown26C;     // offset: 620, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 620) = 1114636288;
        public float Unknown270;     // offset: 624, sz: 4, origin: 1097859072i64, parsed: 15, comment: two packed floats in a QWORD?(1)
        public float Unknown274;     // offset: 628, sz: 4, origin: 1097859072i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 624) = 1097859072i64;
        public float Unknown278;     // offset: 632, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 632) = 0;
        public float Unknown27C;     // offset: 636, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 636) = 1120403456;
        public float Unknown280;     // offset: 640, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 640) = 1125515264;
        public float Unknown284;     // offset: 644, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 644) = 1114636288;
        public float Unknown288;     // offset: 648, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 648) = 1097859072;
        public bool Unknown28C;     // offset: 652, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 652) = 0;

        // missing 3 bytes at offset 652
        // does 652 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding28D;        // offset: 653, sz: 3, comment: auto padding

        public float Unknown290;     // offset: 656, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 656) = 1067030938;
        public float Unknown294;     // offset: 660, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(v1 + 660) = 1075838976;
        public float Unknown298;     // offset: 664, sz: 4, origin: 1083179008, parsed: 4.5        // line:   *(_DWORD *)(v1 + 664) = 1083179008;
        public int Unknown29C;     // offset: 668, sz: 4, origin: 40, parsed: 40        // line:   *(_DWORD *)(v1 + 668) = 40;
        public int Unknown2A0;     // offset: 672, sz: 4, origin: 80, parsed: 80        // line:   *(_DWORD *)(v1 + 672) = 80;
        public int Unknown2A4;     // offset: 676, sz: 4, origin: 160, parsed: 160        // line:   *(_DWORD *)(v1 + 676) = 160;
        public int Unknown2A8;     // offset: 680, sz: 4, origin: 360, parsed: 360        // line:   *(_DWORD *)(v1 + 680) = 360;
        // line: //  *(_QWORD *)(v1 + 688) = 0i64;
        // line: //  *(_QWORD *)(v1 + 696) = 0i64;

        // missing 4 bytes at offset 680
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2AC;        // offset: 684, sz: 4, comment: auto padding

        [NMS(Size = 0xF)]
        public string Unknown2B0;     // offset: 688, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 688), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 688));
        // line:   *(_BYTE *)(v1 + 703) = 0;
        public float Unknown2C0;     // offset: 704, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 704) = 0x40000000;
        // line: //  *(_QWORD *)(v1 + 712) = 0i64;
        // line: //  *(_QWORD *)(v1 + 720) = 0i64;

        // missing 4 bytes at offset 704
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2C4;        // offset: 708, sz: 4, comment: auto padding

        [NMS(Size = 0xF)]
        public string Unknown2C8;     // offset: 712, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 712), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 712));
        // line:   *(_BYTE *)(v1 + 727) = 0;
        public float Unknown2D8;     // offset: 728, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 728) = 1077936128;
        // line: //  *(_QWORD *)(v1 + 736) = 0i64;
        // line: //  *(_QWORD *)(v1 + 744) = 0i64;

        // missing 4 bytes at offset 728
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2DC;        // offset: 732, sz: 4, comment: auto padding

        [NMS(Size = 0xF)]
        public string Unknown2E0;     // offset: 736, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 736), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 736));
        // line:   *(_BYTE *)(v1 + 751) = 0;
        public float Unknown2F0;     // offset: 752, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 752) = 1082130432;
        // line: //  *(_QWORD *)(v1 + 760) = 0i64;
        // line: //  *(_QWORD *)(v1 + 768) = 0i64;

        // missing 4 bytes at offset 752
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2F4;        // offset: 756, sz: 4, comment: auto padding

        [NMS(Size = 0xF)]
        public string Unknown2F8;     // offset: 760, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 760), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 760));
        // line:   *(_BYTE *)(v1 + 775) = 0;
        public float Unknown308;     // offset: 776, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 776) = 1090519040;
        public float Unknown30C;     // offset: 780, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 780) = 1106247680;
        public float Unknown310;     // offset: 784, sz: 4, origin: 1116471296, parsed: 70        // line:   *(_DWORD *)(v1 + 784) = 1116471296;
        public float Unknown314;     // offset: 788, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 788) = 1097859072;
        public float Unknown318;     // offset: 792, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 792) = 1114636288;
        public float Unknown31C;     // offset: 796, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 796) = 1077936128;
        public float Unknown320;     // offset: 800, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 800) = 1109393408;
        public float Unknown324;     // offset: 804, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 804) = 1109393408;
        public float Unknown328;     // offset: 808, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 808) = 1092616192;
        public float Unknown32C;     // offset: 812, sz: 4, origin: 1116471296, parsed: 70        // line:   *(_DWORD *)(v1 + 812) = 1116471296;
        public int Unknown330;     // offset: 816, sz: 4, origin: 110, parsed: 110        // line:   *(_DWORD *)(v1 + 816) = 110;
        public int Unknown334;     // offset: 820, sz: 4, origin: 120, parsed: 120        // line:   *(_DWORD *)(v1 + 820) = 120;
        public int Unknown338;     // offset: 824, sz: 4, origin: 150, parsed: 150        // line:   *(_DWORD *)(v1 + 824) = 150;
        public int Unknown33C;     // offset: 828, sz: 4, origin: 160, parsed: 160        // line:   *(_DWORD *)(v1 + 828) = 160;
        public int Unknown340;     // offset: 832, sz: 4, origin: 93, parsed: 93        // line:   *(_DWORD *)(v1 + 832) = 93;
        public float Unknown344;     // offset: 836, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 836) = 1082130432;
        public float Unknown348;     // offset: 840, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 840) = 1069547520;
        public float Unknown34C;     // offset: 844, sz: 4, origin: 1093664768, parsed: 11        // line:   *(_DWORD *)(v1 + 844) = 1093664768;
        public float Unknown350;     // offset: 848, sz: 4, origin: 1088421888, parsed: 7        // line:   *(_DWORD *)(v1 + 848) = 1088421888;
        public float Unknown354;     // offset: 852, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 852) = 1050253722;
        public float Unknown358;     // offset: 856, sz: 4, origin: 1088421888, parsed: 7        // line:   *(_DWORD *)(v1 + 856) = 1088421888;
        public float Unknown35C;     // offset: 860, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 860) = 1050253722;
        public float Unknown360;     // offset: 864, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 864) = 1114636288;
        public float Unknown364;     // offset: 868, sz: 4, origin: 1117782016, parsed: 80        // line:   *(_DWORD *)(v1 + 868) = 1117782016;
        public float Unknown368;     // offset: 872, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 872) = 1106247680;
        public float Unknown36C;     // offset: 876, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 876) = 1106247680;
        public float Unknown370;     // offset: 880, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 880) = 1084227584;
        public float Unknown374;     // offset: 884, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 884) = 1058642330;
        public float Unknown378;     // offset: 888, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(v1 + 888) = 1060320051;
        public float Unknown37C;     // offset: 892, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 892) = 1109393408;
        public float Unknown380;     // offset: 896, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 896) = 1065353216;
        public float Unknown384;     // offset: 900, sz: 4, origin: 1166315520, parsed: 4242        // line:   *(_DWORD *)(v1 + 900) = 1166315520;
        public float Unknown388;     // offset: 904, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 904) = 1058642330;
        public float Unknown38C;     // offset: 908, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v1 + 908) = 1063675494;
        public float Unknown390;     // offset: 912, sz: 4, origin: 1108082688, parsed: 35        // line:   *(_DWORD *)(v1 + 912) = 1108082688;
        public float Unknown394;     // offset: 916, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 916) = 1101004800;
        public float Unknown398;     // offset: 920, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 920) = 1061997773;
        public float Unknown39C;     // offset: 924, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 924) = 0x40000000;
        public int Unknown3A0;     // offset: 928, sz: 4, origin: 12, parsed: 12        // line:   *(_DWORD *)(v1 + 928) = 12;
        public int Unknown3A4;     // offset: 932, sz: 4, origin: 18, parsed: 18        // line:   *(_DWORD *)(v1 + 932) = 18;
        public float Unknown3A8;     // offset: 936, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 936) = 1065353216;
        public float Unknown3AC;     // offset: 940, sz: 4, origin: 1061158912, parsed: 0.75        // line:   *(_DWORD *)(v1 + 940) = 1061158912;
        public float Unknown3B0;     // offset: 944, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(v1 + 944) = 1060320051;
        public float Unknown3B4;     // offset: 948, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 948) = 0x40000000;
        public float Unknown3B8;     // offset: 952, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 952) = 1045220557;
        public float Unknown3BC;     // offset: 956, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 956) = 1058642330;
        public float Unknown3C0;     // offset: 960, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 960) = 1097859072;
        public float Unknown3C4;     // offset: 964, sz: 4, origin: 1098907648, parsed: 16        // line:   *(_DWORD *)(v1 + 964) = 1098907648;
        public float Unknown3C8;     // offset: 968, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(v1 + 968) = 1060320051;
        public float Unknown3CC;     // offset: 972, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 972) = 1086324736;
        public float Unknown3D0;     // offset: 976, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 976) = 1065353216;
        public float Unknown3D4;     // offset: 980, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 980) = 0x40000000;
        public float Unknown3D8;     // offset: 984, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 984) = 1082130432;
        public float Unknown3DC;     // offset: 988, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 988) = 1065353216;
        public float Unknown3E0;     // offset: 992, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(v1 + 992) = 1075838976;
        public float Unknown3E4;     // offset: 996, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 996) = 1086324736;
        public float Unknown3E8;     // offset: 1000, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1000) = 1077936128;
        public float Unknown3EC;     // offset: 1004, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 1004) = 1086324736;
        public float Unknown3F0;     // offset: 1008, sz: 4, origin: 1048576000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 1008) = 1048576000;
        public float Unknown3F4;     // offset: 1012, sz: 4, origin: 1048576000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 1012) = 1048576000;
        public float Unknown3F8;     // offset: 1016, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 1016) = 1086324736;
        public float Unknown3FC;     // offset: 1020, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1020) = 1077936128;
        public float Unknown400;     // offset: 1024, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 1024) = 1086324736;
        public float Unknown404;     // offset: 1028, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 1028) = 0x40000000;
        public float Unknown408;     // offset: 1032, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 1032) = 1069547520;
        public float Unknown40C;     // offset: 1036, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1036) = 1114636288;
        public float Unknown410;     // offset: 1040, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 1040) = 1092616192;
        public float Unknown414;     // offset: 1044, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1044) = 1114636288;
        public float Unknown418;     // offset: 1048, sz: 4, origin: 1157234688, parsed: 2000        // line:   *(_DWORD *)(v1 + 1048) = 1157234688;
        public int Unknown41C;     // offset: 1052, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(v1 + 1052) = 4;
        public short Unknown420;     // offset: 1056, sz: 2, origin: 0, parsed: 0        // line:   *(_WORD *)(v1 + 1056) = 0;

        // missing 2 bytes at offset 1056
        // does 1056 contain a DWORD?
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding422;        // offset: 1058, sz: 2, comment: auto padding

        public float Unknown424;     // offset: 1060, sz: 4, origin: 1117782016, parsed: 80        // line:   *(_DWORD *)(v1 + 1060) = 1117782016;
        public bool Unknown428;     // offset: 1064, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 1064) = 1;

        // missing 3 bytes at offset 1064
        // does 1064 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding429;        // offset: 1065, sz: 3, comment: auto padding

        public float Unknown42C;     // offset: 1068, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1068) = 1045220557;
        public float Unknown430;     // offset: 1072, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1072) = 1045220557;
        public float Unknown434;     // offset: 1076, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1076) = 1053609165;
        public float Unknown438;     // offset: 1080, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 1080) = 1067030938;
        public bool Unknown43C;     // offset: 1084, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 1084) = 1;
        // line: //  *(_QWORD *)(v1 + 1088) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1096) = 0i64;

        // missing 3 bytes at offset 1084
        // does 1084 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding43D;        // offset: 1085, sz: 3, comment: auto padding

        [NMS(Size = 0xF)]
        public string Unknown440;     // offset: 1088, sz: 15, origin:  "DEATHBLOODSMALL"        // line:   strncpy((char *)(v1 + 1088), "DEATHBLOODSMALL", 0xFui64);
        // line:   strupr((char *)(v1 + 1088));
        // line:   *(_BYTE *)(v1 + 1103) = 0;
        // line: //  *(_QWORD *)(v1 + 1104) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1112) = 0i64;
        [NMS(Size = 0xD)]
        public string Unknown450;     // offset: 1104, sz: 13, origin:  "DEATHBLOODMED"        // line:   strncpy((char *)(v1 + 1104), "DEATHBLOODMED", 0xDui64);
        // line:   strupr((char *)(v1 + 1104));
        // line:   *(_BYTE *)(v1 + 1117) = 0;
        // line: //  *(_QWORD *)(v1 + 1120) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1128) = 0i64;

        // missing 3 bytes at offset 1104
        // does 1104 contain a string which doesn't use all available space?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding45D;        // offset: 1117, sz: 3, comment: auto padding

        [NMS(Size = 0xD)]
        public string Unknown460;     // offset: 1120, sz: 13, origin:  "DEATHBLOODBIG"        // line:   strncpy((char *)(v1 + 1120), "DEATHBLOODBIG", 0xDui64);
        // line:   strupr((char *)(v1 + 1120));
        // line:   *(_BYTE *)(v1 + 1133) = 0;

        // missing 3 bytes at offset 1120
        // does 1120 contain a string which doesn't use all available space?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding46D;        // offset: 1133, sz: 3, comment: auto padding

        public float Unknown470;     // offset: 1136, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 1136) = 1050253722;
        public float Unknown474;     // offset: 1140, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 1140) = 1090519040;
        public float Unknown478;     // offset: 1144, sz: 4, origin: 1099956224, parsed: 18        // line:   *(_DWORD *)(v1 + 1144) = 1099956224;
        public float Unknown47C;     // offset: 1148, sz: 4, origin: 1110704128, parsed: 45        // line:   *(_DWORD *)(v1 + 1148) = 1110704128;
        public float Unknown480;     // offset: 1152, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 1152) = 1101004800;
        public float Unknown484;     // offset: 1156, sz: 4, origin: 1116471296, parsed: 70        // line:   *(_DWORD *)(v1 + 1156) = 1116471296;
        public float Unknown488;     // offset: 1160, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 1160) = 1101004800;
        public float Unknown48C;     // offset: 1164, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 1164) = 1092616192;
        public float Unknown490;     // offset: 1168, sz: 4, origin: 1056964608i64, parsed: 0.5, comment: two packed floats in a QWORD?(1)
        public float Unknown494;     // offset: 1172, sz: 4, origin: 1056964608i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1168) = 1056964608i64;
        public bool Unknown498;     // offset: 1176, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 1176) = 0;

        // missing 3 bytes at offset 1176
        // does 1176 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding499;        // offset: 1177, sz: 3, comment: auto padding

        public int Unknown49C;     // offset: 1180, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(v1 + 1180) = 4;
        public int Unknown4A0;     // offset: 1184, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(v1 + 1184) = 4;
        public float Unknown4A4;     // offset: 1188, sz: 4, origin: 1048576000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 1188) = 1048576000;
        public float Unknown4A8;     // offset: 1192, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1192) = 1061997773;
        public float Unknown4AC;     // offset: 1196, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1196) = 1061997773;
        public float Unknown4B0;     // offset: 1200, sz: 4, origin: 1064514355, parsed: 0.95        // line:   *(_DWORD *)(v1 + 1200) = 1064514355;
        public float Unknown4B4;     // offset: 1204, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1204) = 1036831949;
        public float Unknown4B8;     // offset: 1208, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1208) = 1065353216;
        public float Unknown4BC;     // offset: 1212, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 1212) = 0x40000000;
        public float Unknown4C0;     // offset: 1216, sz: 4, origin: 1088421888, parsed: 7        // line:   *(_DWORD *)(v1 + 1216) = 1088421888;
        public float Unknown4C4;     // offset: 1220, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 1220) = 1092616192;
        public float Unknown4C8;     // offset: 1224, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 1224) = 1058642330;
        public float Unknown4CC;     // offset: 1228, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 1228) = 1050253722;
        public float Unknown4D0;     // offset: 1232, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1232) = 1056964608;
        public float Unknown4D4;     // offset: 1236, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1236) = 1061997773;
        public bool Unknown4D8;     // offset: 1240, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 1240) = 0;

        // missing 3 bytes at offset 1240
        // does 1240 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding4D9;        // offset: 1241, sz: 3, comment: auto padding

        public float Unknown4DC;     // offset: 1244, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(v1 + 1244) = 1060320051;
        public float Unknown4E0;     // offset: 1248, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1248) = 1077936128;
        public float Unknown4E4;     // offset: 1252, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1252) = 1065353216;
        public float Unknown4E8;     // offset: 1256, sz: 4, origin: 1067450368, parsed: 1.25        // line:   *(_DWORD *)(v1 + 1256) = 1067450368;
        public bool Unknown4EC;     // offset: 1260, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 1260) = 0;
        [NMS(Size = 0x80)]
        public string Unknown4ED;     // offset: 1261, sz: 128, origin:  "metadata/simulation/ecosystem/roledescriptiontables/ground/groundtablecommon.mxml"        // line:   strncpy((char *)(v1 + 1261), "metadata/simulation/ecosystem/roledescriptiontables/ground/groundtablecommon.mxml", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 1388) = 0;
        [NMS(Size = 0x80)]
        public string Unknown56D;     // offset: 1389, sz: 128, origin:  "metadata/simulation/ecosystem/roledescriptiontables/air/AirTableCommon.mxml"        // line:   strncpy((char *)(v1 + 1389), "metadata/simulation/ecosystem/roledescriptiontables/air/AirTableCommon.mxml", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 1516) = 0;

        // missing 3 bytes at offset 1389
        // does 1389 contain a string which doesn't use all available space?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding5ED;        // offset: 1517, sz: 3, comment: auto padding

        public float Unknown5F0;     // offset: 1520, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 1520) = 1067030938;
        public float Unknown5F4;     // offset: 1524, sz: 4, origin: 1066192077, parsed: 1.1        // line:   *(_DWORD *)(v1 + 1524) = 1066192077;
        // line: //  *(_QWORD *)(v1 + 1528) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1536) = 0i64;
        [NMS(Size = 5)]
        public string Unknown5F8;     // offset: 1528, sz: 5, origin:  "FUEL1"        // line:   strncpy((char *)(v1 + 1528), "FUEL1", 5ui64);
        // line:   strupr((char *)(v1 + 1528));
        // line:   *(_BYTE *)(v1 + 1533) = 0;
        // line: //  *(_QWORD *)(v1 + 1544) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1552) = 0i64;

        // missing 11 bytes at offset 1528
        // does 1528 contain a string which doesn't use all available space?
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] Padding5FD;        // offset: 1533, sz: 11, comment: auto padding

        [NMS(Size = 5)]
        public string Unknown608;     // offset: 1544, sz: 5, origin:  "TECH1"        // line:   strncpy((char *)(v1 + 1544), "TECH1", 5ui64);
        // line:   strupr((char *)(v1 + 1544));
        // line:   *(_BYTE *)(v1 + 1549) = 0;
        // line: //  *(_QWORD *)(v1 + 1560) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1568) = 0i64;

        // missing 11 bytes at offset 1544
        // does 1544 contain a string which doesn't use all available space?
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] Padding60D;        // offset: 1549, sz: 11, comment: auto padding

        [NMS(Size = 4)]
        public string Unknown618;     // offset: 1560, sz: 4, origin:  "COM1"        // line:   strncpy((char *)(v1 + 1560), "COM1", 4ui64);
        // line:   strupr((char *)(v1 + 1560));
        // line:   *(_BYTE *)(v1 + 1564) = 0;
        // line: //  *(_QWORD *)(v1 + 1576) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1584) = 0i64;

        // missing 12 bytes at offset 1560
        // does 1560 contain a string which doesn't use all available space?
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding61C;        // offset: 1564, sz: 12, comment: auto padding

        [NMS(Size = 5)]
        public string Unknown628;     // offset: 1576, sz: 5, origin:  "FUEL1"        // line:   strncpy((char *)(v1 + 1576), "FUEL1", 5ui64);
        // line:   strupr((char *)(v1 + 1576));
        // line:   *(_BYTE *)(v1 + 1581) = 0;
        // line: //  *(_QWORD *)(v1 + 1592) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1600) = 0i64;

        // missing 11 bytes at offset 1576
        // does 1576 contain a string which doesn't use all available space?
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] Padding62D;        // offset: 1581, sz: 11, comment: auto padding

        [NMS(Size = 5)]
        public string Unknown638;     // offset: 1592, sz: 5, origin:  "TECH1"        // line:   strncpy((char *)(v1 + 1592), "TECH1", 5ui64);
        // line:   strupr((char *)(v1 + 1592));
        // line:   *(_BYTE *)(v1 + 1597) = 0;
        // line: //  *(_QWORD *)(v1 + 1608) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1616) = 0i64;

        // missing 11 bytes at offset 1592
        // does 1592 contain a string which doesn't use all available space?
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] Padding63D;        // offset: 1597, sz: 11, comment: auto padding

        [NMS(Size = 4)]
        public string Unknown648;     // offset: 1608, sz: 4, origin:  "COM1"        // line:   strncpy((char *)(v1 + 1608), "COM1", 4ui64);
        // line:   strupr((char *)(v1 + 1608));
        // line:   *(_BYTE *)(v1 + 1612) = 0;
        // line: //  *(_QWORD *)(v1 + 1624) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1632) = 0i64;

        // missing 12 bytes at offset 1608
        // does 1608 contain a string which doesn't use all available space?
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding64C;        // offset: 1612, sz: 12, comment: auto padding

        [NMS(Size = 0xC)]
        public string Unknown658;     // offset: 1624, sz: 12, origin:  "CREATURELOOT"        // line:   strncpy((char *)(v1 + 1624), "CREATURELOOT", 0xCui64);
        // line:   strupr((char *)(v1 + 1624));
        // line:   *(_BYTE *)(v1 + 1636) = 0;
        // line: //  *(_QWORD *)(v1 + 1640) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1648) = 0i64;

        // missing 4 bytes at offset 1624
        // does 1624 contain a string which doesn't use all available space?
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding664;        // offset: 1636, sz: 4, comment: auto padding

        [NMS(Size = 0xC)]
        public string Unknown668;     // offset: 1640, sz: 12, origin:  "CREATURELOOT"        // line:   strncpy((char *)(v1 + 1640), "CREATURELOOT", 0xCui64);
        // line:   strupr((char *)(v1 + 1640));
        // line:   *(_BYTE *)(v1 + 1652) = 0;
        // line: //  *(_QWORD *)(v1 + 1656) = 0i64;
        // line: //  *(_QWORD *)(v1 + 1664) = 0i64;

        // missing 4 bytes at offset 1640
        // does 1640 contain a string which doesn't use all available space?
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding674;        // offset: 1652, sz: 4, comment: auto padding

        [NMS(Size = 0xC)]
        public string Unknown678;     // offset: 1656, sz: 12, origin:  "CREATURELOOT"        // line:   strncpy((char *)(v1 + 1656), "CREATURELOOT", 0xCui64);
        // line:   result = strupr((char *)(v1 + 1656));
        // line:   *(_BYTE *)(v1 + 1668) = 0;
        // line:   return result;
        // line: }

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding684; // manual padding to fit size
    }
}
