using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class DownloadVideoActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("download video activity started...");
        }
    }
}
