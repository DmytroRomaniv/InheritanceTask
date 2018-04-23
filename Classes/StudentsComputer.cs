using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceTask.Enums;

namespace InheritanceTask.Classes
{
    class StudentsComputer: Computer
    {
        public override void BuildPC()
        {
            this.CPU = BIPS.i5;
            this.GPU = 4;
            this.RAM = 4;
        }

        public override string ToString()
        {
            return "Students " + base.ToString();
        }
    }
}