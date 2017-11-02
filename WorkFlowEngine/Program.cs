using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //var noWorkflow = new WorkFlow("no workflow", new List<IActivity> {});
            //noWorkflow.RunAll();

            var uploadVideoWorkflow = new WorkFlow("upload video", new List<IActivity>
            {
                new UploadVideoActivity(),
                new CallWebServiceActivity(),
                new SendEmailActivity(),
                new ChangeStatusActivity()
            });

            uploadVideoWorkflow.RunAll();

            var downloadVideoWorkflow = new WorkFlow("download video", new List<IActivity>
            {
                new DownloadVideoActivity(),
                new CompressVideoActivity()
            });

            downloadVideoWorkflow.RunAll();

            Console.ReadLine();
        }
    }
}
