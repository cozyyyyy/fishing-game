using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fishingGame;
using System.Drawing;

namespace fishingGame
{
    class iwashi:fish
    {
        //コンストラクタ
        public iwashi(Bitmap bmp, int x, int y, int w, int h, int sc, int spd)
            :base(bmp, x, y, w, h,sc, spd)
        {
        }

           //オーバーライド
        public override bool eat(int kind, int x, int y, int w, int h)
        {
            if (kind == 1)
            {
                if (x <= mX + mW && mX <= x + w &&
                   y <= mY + mH && mY <= y + h)
                {
                    //食いついた
                    return true;
                }
            }
            return false;
        }
    }
}
