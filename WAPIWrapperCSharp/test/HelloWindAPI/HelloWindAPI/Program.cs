using WAPIWrapperCSharp;

namespace HelloWindAPI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WindAPI w = new WindAPI();
            w.start();

            w.stop();
        }
    }
}