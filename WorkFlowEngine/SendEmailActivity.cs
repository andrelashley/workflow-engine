using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class SendEmailActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Sending email activity started...");
        }
    }
}
