using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class RightTriangle : IsoscelesTriangle
    {
        public RightTriangle
            (double side, double @base, int startX, int startY, int lineWidth, Color color) :
            base(side, @base/2, startX, startY, lineWidth, color)
        { }
        public override double GetHeight() => Math.Sqrt(Side*Side-Base*Base);
        public override double GetArea() => GetHeight()*Base / 2;
        public override double GetPerimeter() => Side+Base+ GetHeight();
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX, StartY),
                new Point(StartX+(int)Base, StartY),
                new Point(StartX+(int)Base, StartY-(int)GetHeight())
            };
            e.Graphics.DrawPolygon(pen, points);
        }
        public override void DrawHeight(PaintEventArgs e)
        { }
        public override void Info(PaintEventArgs e)
        {
            base.Info(e);
        }
    }
}
