using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal interface IHaveAxisLines
    {
        double GetFocalLength();
        void DrawAxisLines(PaintEventArgs e);
    }
}
