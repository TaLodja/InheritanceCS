using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Ellipse : Shape, IHaveAxisLines
    {
        double majorAxis;
        double minorAxis;
        public double MajorAxis
        {
            get => majorAxis;
            set => majorAxis = FilterSize(value);
        }
        public double MinorAxis
        {
            get => minorAxis;
            set => minorAxis = FilterSize(value);
        }
        public Ellipse
            (
            double majorAxis, double minorAxis,
            int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }
        public double GetFocalLength() => Math.Sqrt(MajorAxis * MajorAxis - MinorAxis * MinorAxis);
        public override double GetArea() => 3.14 * MajorAxis * MinorAxis / 4;
        public override double GetPerimeter() => 2 * 3.14 * Math.Sqrt((MajorAxis * MajorAxis + MinorAxis * MinorAxis) / 8);
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)MajorAxis, (float)MinorAxis);
        }
        public void DrawAxisLines(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawLine(pen, StartX, (float)(StartY + MinorAxis / 2), (float)(StartX + MajorAxis), (float)(StartY + MinorAxis / 2));
            e.Graphics.DrawLine(pen, StartX + (float)(MajorAxis / 2 - GetFocalLength() / 2), StartY, StartX + (float)(MajorAxis / 2 - GetFocalLength() / 2), StartY + (float)MinorAxis);
            e.Graphics.DrawLine(pen, StartX + (float)(MajorAxis / 2 + GetFocalLength() / 2), StartY, StartX + (float)(MajorAxis / 2 + GetFocalLength() / 2), StartY + (float)MinorAxis);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Большая ось: {MajorAxis}");
            Console.WriteLine($"Малая ось: {MinorAxis}");
            Console.WriteLine($"Межосевое расстояние: {GetFocalLength()}");
            base.Info(e);
            DrawAxisLines(e);
        }
    }
}
