using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceTask.Enums;

namespace InheritanceTask.Classes
{
    abstract class Computer: IComparable
    {
        public BIPS CPU { get; set; }
        public int GPU { get; set; }
        public int RAM { get; set; }
        public double Price
        {
            get
            {
                double price = GPU * 100 + RAM * 10 + (int)CPU * 1.25;

                return price;
            }
        }

        public Computer()
        {
            BuildPC();
        }

        public int CompareTo(Object _obj)
        {
            if(_obj is Computer)
            {
                Computer computer = _obj as Computer;
                if(this.Price > computer.Price)
                {
                    return 1;
                }
                else if(this.Price == computer.Price)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public double DoTask(int _neededCPU, int _neededGPU, int _neededRAM)
        {
            double CPUtime = _neededCPU / (int)CPU;
            double GPUtime = _neededGPU / GPU;
            double RAMtime = _neededRAM / RAM;

            double time = Math.Max(CPUtime, Math.Max(GPUtime, RAMtime));

            return time;
        }

        public override string ToString()
        {
            string output = "Computer\n";
            output += "CPU: " + CPU + "\n";
            output += "Billion Instrucuions Per Second: " + (int)CPU + "\n";
            output += "GPU: " + GPU + "\n";
            output += "RAM: " + RAM + "\n";
            output += "Price: " + Price + "$\n";

            return output;
        }

        abstract public void BuildPC();
    }
}