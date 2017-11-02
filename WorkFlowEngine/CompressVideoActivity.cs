using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class CompressVideoActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Compress video activity started...");
        }
    }
}
