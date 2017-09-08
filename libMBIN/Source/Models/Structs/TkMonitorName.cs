using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libMBIN.Models.Structs
{
    public class TkMonitorName :NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string name;
    }
}
