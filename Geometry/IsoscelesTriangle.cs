using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class IsoscelesTriangle : Triangle
    {
        double side;
        double @base;
        public double Side
        {
            get => side;
            set => side = FilterSize(value);
        }
        public double Base
        {
            get => @base;
            set => @base = FilterSize(value);
        }
        public IsoscelesTriangle
            (double side, double @base,
            int startX, int startY, int lineWidth, Color color):
            base(startX, startY, lineWidth, color)
        {
            Side = side;
            Base = @base;
        }
        public override double GetHeight() => Math.Sqrt(Side * Side - Base * Base / 4);
        public override double GetArea() => GetHeight() * Base / 2;
        public override double GetPerimeter() => Side * 2 + Base;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX, StartY),
                new Point(StartX+(int)Base, StartY),
                new Point(StartX+(int)Base/2, StartY-(int)GetHeight())
            };
            e.Graphics.DrawPolygon(pen, points);
        }
        public virtual void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawLine(pen, StartX + (int)Base / 2, StartY - (int)GetHeight(), StartX + (int)Base / 2, StartY);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Сторона треугольника: {Side}");
            Console.WriteLine($"Основание трегольника: {Base}");
            base.Info(e);
            DrawHeight(e);
        }
    }
}
