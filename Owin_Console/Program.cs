using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Owin_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8088";
            var startOpts=new StartOptions(url)
            {
                
            };
            using (WebApp.Start<Startup>(startOpts))
            {
                Console.WriteLine("Server run at "+url+",");
            }
        }
    }
}
