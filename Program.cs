using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceTask.Classes;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerList task = new ComputerList();
            task.AddRandomComputors();
            task.BestPC(1500, 10, 10);
            Console.ReadKey();
        }
    }
}