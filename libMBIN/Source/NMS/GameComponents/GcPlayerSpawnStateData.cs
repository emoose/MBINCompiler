using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x0CBFEA8C3D0A1AE37)]
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        /* 0x000 */ public Vector4f PlayerPositionInSystem;
        /* 0x010 */ public Vector4f PlayerTransformAt;
        /* 0x020 */ public Vector4f ShipPositionInSystem;
        /* 0x030 */ public Vector4f ShipTransformAt;
		public enum LastKnownPlayerStateEnum { OnFoot, InShip, InStation, AboardFleet }
		public LastKnownPlayerStateEnum LastKnownPlayerState;
		[NMS(Size = 0xC, Ignore = true)]
        /* 0x044 */ public byte[] Padding54; 
		/* 0x050 */ public Vector4f FreighterPositionInSystem;
		/* 0x060 */ public Vector4f FreighterTransformAt;
		/* 0x070 */ public Vector4f FreighterTransformUp;
    }
}
