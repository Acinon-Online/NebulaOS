using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NebulaOSKernal.SysApp;
using sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace NebulaOSKernal
{
    public static class StartGUI
    {
        public static string Name = "GUI App";
        public static string Description = "Display the GUI";
        public static string Authour = "AcinonX";
        public static string ver = "a1";
        public static bool isRelease = false;
        public static void AppStart()
        {
            Run();
        }
        public static void Run()
        {
            Canvas vgaCanv;

            vgaCanv = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            vgaCanv.Clear();
            Pen pen = new Pen(Color.Red);

            // A red Point
            vgaCanv.DrawPoint(pen, 69, 69);

            // A GreenYellow horizontal line
            pen.Color = Color.GreenYellow;
            vgaCanv.DrawLine(pen, 250, 100, 400, 100);

            // An IndianRed vertical line
            pen.Color = Color.IndianRed;
            vgaCanv.DrawLine(pen, 350, 150, 350, 250);

            // A MintCream diagonal line
            pen.Color = Color.MintCream;
            vgaCanv.DrawLine(pen, 250, 150, 400, 250);

            // A PaleVioletRed rectangle
            pen.Color = Color.PaleVioletRed;
            vgaCanv.DrawRectangle(pen, 350, 350, 80, 60);

            // A LimeGreen rectangle
            pen.Color = Color.LimeGreen;
            vgaCanv.DrawRectangle(pen, 450, 450, 80, 60);
        }
    }
}
