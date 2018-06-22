using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace fabiostefani.io.Rabbit.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(cfg => { cfg.Service(x => new ContentConsumerService()); });
        }
    }
}
