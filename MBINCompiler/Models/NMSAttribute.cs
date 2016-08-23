using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter)]
    public class NMSAttribute : Attribute
    {
        private int size;
        public int Size
        {
          get
          {
              return size;
          }
          set
          {
              size = value;
          }
        }

        private bool ignore;
        public bool Ignore
        {
            get
            {
                return ignore;
            }
            set
            {
                ignore = value;
            }
        }

        private object defaultValue;
        public object DefaultValue
        {
            get
            {
                return defaultValue;
            }
            set
            {
                defaultValue = value;
            }
        }

        public NMSAttribute() 
        {
            size = 0;
            ignore = false;
            defaultValue = null;
        }
    }
}