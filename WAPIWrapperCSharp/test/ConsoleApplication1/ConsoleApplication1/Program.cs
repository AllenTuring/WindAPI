using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WAPIWrapperCSharp;
using WindCommon;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WindAPI w = new WindAPI();
            w.start();

            WindData wd = w.wsd("600000.SH", "MACD", "ED-1M", "2014-12-16", "MACD_L=26;MACD_S=12;MACD_N=9;MACD_IO=1;Fill=Previous");
            
            
            string str = WindDataMethod.WindDataToString(wd, "wsd");
            Console.Write(str);
            Console.Read();

            w.stop();
        }
    }
}
