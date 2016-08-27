namespace MBINCompiler.Models.Structs
{
	public class TkJointBindingData : NMSTemplate
	{
		[NMS(Size = 16)]
		public float[] InvBindMatrix; // 4x4 matrix
		
		[NMS(Size = 3)]
		public float[] BindTranslate; // Vector3f
		
		[NMS(Size = 4)]
		public float[] BindRotate; // Quaternion
		
		[NMS(Size = 3)]
		public float[] BindScale; // Vector3f
	}
}