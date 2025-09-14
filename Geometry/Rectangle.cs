using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    internal class Rectangle: Shape, IHaveDiagonal
    {
        double width;
        double height;
        public double Width
        {
            get => width;
            set => width = FilterSize(value);
        }
        public double Height
        {
            get => height;
            set => height = FilterSize(value);
        }
        public Rectangle
            (
            double width, double height,
            int startX, int startY, int lineWidth, Color color
            ): base(startX, startY, lineWidth, color)
        {
            Width = width;
            Height = height;
        }
        public double GetDiagonal() => Math.Sqrt(Width*Width+Height*Height);
        public override double GetArea()=>Width*Height;
        public override double GetPerimeter() => (Width + Height)*2;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
        }
        public void DrawDiagonal(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine(pen, StartX, StartY, (int)(StartX+Width), (int)(StartY+Height));
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Диагональ: {GetDiagonal()}");
            base.Info(e);
            DrawDiagonal(e);
        }
    }
}
