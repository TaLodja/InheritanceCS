using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Monitor: IHaveDiagonal
    {
        double Width;
        double Height;
        string Matrix;
        int refreshRate;
        public double GetDiagonal()
        {
            return 27;
        }
        public void DrawDiagonal(System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
