using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMetalBallComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string File;
        ///* 0x080 */ public Root;    // don't know what type
        /* 0x0A0 */ public float Radius;
        ///* 0x0B0 */ public MinSize;
        ///* 0x0C0 */ public MaxSize;
    }
}
