using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NebulaOSKernal
{
    public class Kernel : Sys.Kernel
    {
        private readonly Bitmap bitmap = new Bitmap(10, 10,
                new byte[] { 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255,
                    23, 59, 88, 255, 0, 255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255, 23, 59, 88, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255, 153, 57, 12, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 0, 255, 243, 255, 153, 57, 12, 255, 23, 59, 88, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243,
                    255, 0, 255, 243, 255, 0, 255, 243, 255, 72, 72, 72, 255, 72, 72, 72, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 72, 72,
                    72, 255, 72, 72, 72, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 10, 66, 148, 255, 10, 66, 148, 255,
                    10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148,
                    255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, }, ColorDepth.ColorDepth32);

        protected override void BeforeRun()
        {
            Console.WriteLine("{0} Initialize Sys Components", "[Main Task]");
            Console.WriteLine("{0} Setup VGA Driver", "[Task]");
            Console.Clear();
            Console.WriteLine("Welcome to NebulaOS! This is the integrated kernal shell; type a command or type 'help' to continue.");
            /*vgaCanv = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            vgaCanv.Clear();*/
        }

        protected override void Run()
        {
            while (true)
            {
                Console.Write(DateTime.Now.ToString());
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("> ");
                string command = Console.ReadLine();

                switch (command)
                {

                    /*case "shutdown":
                        {
                            Deboot.ShutDown();

                            break;

                        }*/

                    case "help":

                        {

                            Console.WriteLine("... thanks - thank you message");

                            Console.WriteLine("... about - OS Information ");

                            break;

                        }

                    case "about":

                        {

                            Console.WriteLine("About System:");
                            Console.WriteLine("-=== OS Version ===-");
                            Console.WriteLine(".... Kernal Version: a1.0");
                            break;

                        }

                    case "reboot":
                        {

                            //Deboot.Reboot();

                            break;

                        }

                    case "thanks":
                        {

                            Console.WriteLine("Thanks to every user and contributer of this NebulaOS");
                            Console.WriteLine("Special Mentions:");
                            Console.WriteLine("Special Mentions:");

                            break;

                        }
                    case "TestApp":
                        {
                            TestApp.AppStart();
                            break;
                        }
                    case "StartGUI":
                        {
                            StartGUI.AppStart();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid command, Please try again.");

                            command = null; break;
                        }
                }

            }
        }
    }
}
