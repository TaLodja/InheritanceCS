using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class EquilaterialTriangle: IsoscelesTriangle
    {
        public EquilaterialTriangle
            (double side, int startX, int startY, int lineWidth, Color color):
            base(side, side, startX, startY, lineWidth, color)
        { }
    }
}
