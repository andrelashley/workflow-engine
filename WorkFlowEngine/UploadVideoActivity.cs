using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class UploadVideoActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Upload activity started...");
        }
    }
}
