using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public void Encode(Video video) 
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000); 
        }
    }
}
