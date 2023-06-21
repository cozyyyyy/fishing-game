using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;   // Bitmapの使用に必要

namespace fishingGame
{
    class fish
    {
        private Bitmap mBMP;                        // キャラの画像
        public int mX { get; protected set; }       // 画像の座標
        public int mY { get; protected set; }       // 画像の座標
        public int mW { get; protected set; }       // 画像の幅
        public int mH { get; protected set; }       // 画像の高さ
        public int mScreen { get; protected set; }  // 画面の幅
        public int mSpd { get; protected set; }   //画像の速さ

        // コンストラクタ
        public fish(Bitmap bmp, int x, int y, int w, int h, int sc, int spd)
        {
            mBMP = bmp;
            mX = x;
            mY = y;
            mW = w;
            mH = h;
            mScreen = sc;
            mSpd = spd;
        }

        // キャラ表示メソッド
        public void disp(Graphics g)
        {
            g.DrawImage(mBMP, mX, mY, mW, mH);
        }

        // 餌食べるメソッド
        public virtual bool eat(int kind, int x, int y, int w, int h)
        {
            if (x <= mX + mW && mX <= x + w &&
                y <= mY + mH && mY <= y + h)
            {
                //食いついた
                return true;
            }
            return false;
        }
        public void reset()
        {
            //魚の縦位置をランダムで決める
            Random myObject = new Random();
            int ranNum = myObject.Next(0, 300);
            mY = ranNum;
            //魚の位置を左端にリセット
            mX = 0 - mW;

        }
        public void move()
        {
            mX += mSpd;
            if(mX >= mScreen)
            {
                reset();
            }
        }
        public virtual int point(int pnt)
        {
            pnt += 10;
            return (pnt);
        }

        public void speed()
        {
            mSpd += 3;
        }
    }
}
