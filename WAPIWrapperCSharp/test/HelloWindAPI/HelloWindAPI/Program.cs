using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WAPIWrapperCSharp;

namespace HelloWindAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            WindAPI w = new WindAPI();
            w.start();



            w.stop();
        }
    }
}
