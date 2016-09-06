namespace MBINCompiler.Models.Structs
{
    public class GcShipHUDTargetIconData : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: char *__fastcall sub_14014BC70(char *a1)
        // line: {
        // line:   char *v1; // rdi@1
        // line:   char *result; // rax@1
        // line:   v1 = a1;
        [NMS(Size = 0x80)]
        public string Unknown0;     // offset: 0, sz: 128, origin:  "TEXTURES\\UI\\HUD\\LINES\\LINECORNERSOLID.DDS"        // line:   strncpy(a1, "TEXTURES\\UI\\HUD\\LINES\\LINECORNERSOLID.DDS", 0x80ui64);
        // line:   v1[127] = 0;
        [NMS(Size = 0x80)]
        public string Unknown80;     // offset: 128, sz: 128, origin:  "TEXTURES\\UI\\HUD\\LINES\\LINESOLID.DDS"        // line:   strncpy(v1 + 128, "TEXTURES\\UI\\HUD\\LINES\\LINESOLID.DDS", 0x80ui64);
        // line:   v1[255] = 0;
        [NMS(Size = 0x80)]
        public string Unknown100;     // offset: 256, sz: 128, origin:  "TEXTURES\\UI\\HUD\\LINES\\LINEVERTSOLID.DDS"        // line:   strncpy(v1 + 256, "TEXTURES\\UI\\HUD\\LINES\\LINEVERTSOLID.DDS", 0x80ui64);
        // line:   v1[383] = 0;
        [NMS(Size = 0x80)]
        public string Unknown180;     // offset: 384, sz: 128, origin:  "TEXTURES\\UI\\HUD\\LINES\\LINECORNERGLOW.DDS"        // line:   strncpy(v1 + 384, "TEXTURES\\UI\\HUD\\LINES\\LINECORNERGLOW.DDS", 0x80ui64);
        // line:   v1[511] = 0;
        [NMS(Size = 0x80)]
        public string Unknown200;     // offset: 512, sz: 128, origin:  "TEXTURES\\UI\\HUD\\LINES\\LINEGLOW.DDS"        // line:   strncpy(v1 + 512, "TEXTURES\\UI\\HUD\\LINES\\LINEGLOW.DDS", 0x80ui64);
        // line:   v1[639] = 0;
        [NMS(Size = 0x80)]
        public string Unknown280;     // offset: 640, sz: 128, origin:  "TEXTURES\\UI\\HUD\\LINES\\LINEVERTGLOW.DDS"        // line:   result = strncpy(v1 + 640, "TEXTURES\\UI\\HUD\\LINES\\LINEVERTGLOW.DDS", 0x80ui64);
        // line:   v1[767] = 0;
        // line:   return result;
        // line: }
    }
}
