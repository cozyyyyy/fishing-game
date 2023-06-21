using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace fishingGame
{
    class ankou : fish
    {
        public ankou(Bitmap bmp, int x, int y, int w, int h, int sc, int spd)
            : base(bmp, x, y, w, h, sc, spd)
        {

        }

        public override int point(int pnt)
        {
            pnt += 20;
            return (pnt);
        }
    }    
}
