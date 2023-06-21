using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;   // Bitmap�̎g�p�ɕK�v

namespace fishingGame
{
    class fish
    {
        private Bitmap mBMP;                        // �L�����̉摜
        public int mX { get; protected set; }       // �摜�̍��W
        public int mY { get; protected set; }       // �摜�̍��W
        public int mW { get; protected set; }       // �摜�̕�
        public int mH { get; protected set; }       // �摜�̍���
        public int mScreen { get; protected set; }  // ��ʂ̕�
        public int mSpd { get; protected set; }   //�摜�̑���

        // �R���X�g���N�^
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

        // �L�����\�����\�b�h
        public void disp(Graphics g)
        {
            g.DrawImage(mBMP, mX, mY, mW, mH);
        }

        // �a�H�ׂ郁�\�b�h
        public virtual bool eat(int kind, int x, int y, int w, int h)
        {
            if (x <= mX + mW && mX <= x + w &&
                y <= mY + mH && mY <= y + h)
            {
                //�H������
                return true;
            }
            return false;
        }
        public void reset()
        {
            //���̏c�ʒu�������_���Ō��߂�
            Random myObject = new Random();
            int ranNum = myObject.Next(0, 300);
            mY = ranNum;
            //���̈ʒu�����[�Ƀ��Z�b�g
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
