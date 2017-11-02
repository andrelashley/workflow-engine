using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class CallWebServiceActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Call web service activity started...");
        }
    }
}
