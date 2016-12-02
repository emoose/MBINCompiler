using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkMaterialMetaData : NMSTemplate // size = 0x6A4
    {
        ///* 0x000 */ public ExternalMaterial;
        public int Shader;
        /* 0x080 */ public string[] ShaderValues()
        {
            return new[] { "UberShader", "Sky", "Screen", "UberHack" };
        }
        /* 0x084 */ public bool Transaprent;
        /* 0x088 */ public int TransparencyLayerID;
        /* 0x08C */ public bool Additive;
        /* 0x08D */ public bool VertexColour;
        /* 0x08E */ public bool DisableZTest;
        /* 0x08F */ public bool Unlit;
        /* 0x090 */ public bool ReceiveShadow;
        /* 0x091 */ public bool CastShadow;
        /* 0x092 */ public bool ShadowOnly;
        /* 0x094 */ public float Roughness;
        /* 0x098 */ public bool RoughnessMask;
        /* 0x099 */ public bool Metallic;
        /* 0x09A */ public bool MetallicMask;
        /* 0x09B */ public bool SubSurfaceMask;
        /* 0x09C */ public bool ParallaxMapped;
        /* 0x09D */ public bool RefractionMap;
        ///* 0x09E */ public DetailDiffuse;
        ///* 0x11E */ public DetailNormal;
        /* 0x1A0 */ public float DetailTiling;
        /* 0x1A4 */ public float MultiplyDetailTiling;
        /* 0x1A8 */ public int DetailImages;
        /* 0x1AC */ public int MultiplyDetailImages;
        /* 0x1B0 */ public bool A0Map;
        /* 0x1B1 */ public bool MultiplySecondUVSet;
        /* 0x1B4 */ public float NormalTiling;
        /* 0x1B8 */ public bool SpaceObject;
        /* 0x1BC */ public float Glow;
        /* 0x1C0 */ public float GlowMask;
    }
}
