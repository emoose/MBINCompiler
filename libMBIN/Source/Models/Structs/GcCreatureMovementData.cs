using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
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
