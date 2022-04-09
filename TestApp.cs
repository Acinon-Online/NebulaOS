using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NebulaOSKernal.SysApp;

namespace NebulaOSKernal
{
    public static class TestApp
    {
        public static string Name = "Testing Applicatoin";
        public static string Description = "An app for testing purposes";
        public static string Authour = "AcinonX";
        public static string ver = "v1";
        public static bool isRelease = true;
        public static void AppStart()
        {
            Run();
        }
        public static void Run()
        {
            Console.WriteLine("This is an app");
        }
    }
}
