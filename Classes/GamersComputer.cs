using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceTask.Enums;

namespace InheritanceTask.Classes
{
    class GamersComputer: Computer
    {
        public override void BuildPC()
        {
            this.CPU = BIPS.i7EE;
            this.GPU = 8;
            this.RAM = 8;
        }

        public override string ToString()
        {
            return "Gamers " + base.ToString();
        }
    }
}