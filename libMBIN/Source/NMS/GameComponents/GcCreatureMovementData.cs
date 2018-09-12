using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5B969A12800050F)]
    public class GcCreatureMovementData : NMSTemplate
    {
        public List<GcCreatureMoveAnimData> Anims;

        public float MoveRange;
        public float MoveSpeedScale;
        public float HeightMin;
        public float HeightMax;
        public float HeightTime;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
    }
}
