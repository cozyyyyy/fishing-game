using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;         // Bitmapの使用に必要
using System.Windows.Forms;   // キーボードの判定に必要


namespace fishingGame
{
    class lure
    {

        private Bitmap mBMP;                      // キャラの画像
        public int mX { get; private set; }       // 画像の座標
        public int mY { get; private set; }       // 画像の座標
        public int mW { get; private set; }       // 画像の幅
        public int mH { get; private set; }       // 画像の高さ
        public int mKind { get; private set; }    // ルアーの種類


        // コンストラクタ
        public lure(Bitmap bmp, int x, int y, int w, int h, int kind)
        {
            mBMP = bmp;
            mX = x;
            mY = y;
            mW = w;
            mH = h;
            mKind = kind;
        }


        // キャラ表示メソッド
        public void disp(Graphics g)
        {
            g.DrawImage(mBMP, mX, mY, mW, mH);
        }


        // キャラを動かすメソッド
        public void move(Keys k)
        {
            //キー入力処理
            if (k == Keys.Left)
            {
                mX -= 5;
            }
            if (k == Keys.Right)
            {
                mX+= 5;
            }
            if (k == Keys.Up)
            {
                mY -= 5;
            }
            if (k == Keys.Down)
            {
                mY += 5;
            }

        }

        public void change(int kind)
        {
            if(kind == 1)
            {
                mBMP = fishingGame.Properties.Resources.lure_bug;
                mKind = 1;
            }
            else
            {
                mBMP = fishingGame.Properties.Resources.lure_fish;
                mKind = 2;
            }
        }
    }
}
