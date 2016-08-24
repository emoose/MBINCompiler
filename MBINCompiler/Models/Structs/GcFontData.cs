using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
	public class GcFontData : NMSTemplate
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
		public string File;
		public int MinCharWidth;
	}
}
