using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class ChangeStatusActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("change status activity started...");
        }
    }
}
