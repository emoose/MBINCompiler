using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs {

    public class GcInventoryTableEntry : NMSTemplate {
    	public string Id;

        public int MinSize;
        public int MaxSize;

        public string[] SizeType(){
            return new[] {
                "SciSmall", "SciMedium", "SciLarge", 
                "FgtSmall", "FgtMedium", "FgtLarge", 
                "ShuSmall", "ShtMedium", "ShtLarge", 
                "DrpSmall", "DrpMedium", "DrpLarge", 
                "WeaponSmall", "WeaponMedium", "WeaponLarge" 
            };
        }
    }

}
