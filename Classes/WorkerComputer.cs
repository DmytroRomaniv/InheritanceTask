using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceTask.Enums;

namespace InheritanceTask.Classes
{
    class WorkerComputer: Computer
    {
        public override void BuildPC()
        {
            this.CPU = BIPS.QX6700;
            this.GPU = 2;
            this.RAM = 2;
        }

        public override string ToString()
        {
            return "Workers " + base.ToString();
        }
    }
}