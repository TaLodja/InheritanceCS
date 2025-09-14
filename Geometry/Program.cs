using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            //e.Graphics.DrawLine(new Pen(Color.AliceBlue, 10), 100, 100, 500, 500);

            //Shape shape = new Shape(0,0,0,System.Drqwing.Color.Aquamarine);
            Rectangle rectangle = new Rectangle(150, 100, 310, 200, 1, Color.Aquamarine);
            rectangle.Info(e);

            Square square = new Square(80, 500, 200, 3, Color.Red);
            square.Info(e);

            Ellipse ellipse = new Ellipse(80, 50, 600, 200, 1, Color.Azure);
            ellipse.Info(e);

            Circle circle = new Circle(80, 700, 200, 3, Color.BlueViolet);
            circle.Info(e);

            IsoscelesTriangle iTriangle = new IsoscelesTriangle(100, 80, 500, 400, 1, Color.CornflowerBlue);
            iTriangle.Info(e);

            EquilaterialTriangle eTriangle = new EquilaterialTriangle(80, 600, 400, 3, Color.DarkSeaGreen);
            eTriangle.Info(e);

            RightTriangle rTriangle = new RightTriangle(100, 80, 700, 400, 3, Color.GreenYellow);
            rTriangle.Info(e);
        }
        static void GetDiagonal(IHaveDiagonal d)
        {
            Console.WriteLine(d.GetDiagonal());
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        //[DllImport("kernel32.dll")]
        //public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
