using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSinTask
{
    public sealed class infoClass
    {
        public int cpuZ { get; set; }

        public int ramZ { get; set; }
        public int gpuZ { get; set; }
        public string[] ipArray { get; set; }

        public DateTime timeZ { get; set; }

        public int timeIndex { get; set; }
    }
}
