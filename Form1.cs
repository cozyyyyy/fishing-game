using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fishingGame
{

    public partial class Form1 : Form
    {
        iwashi Iwashi;
        utsubo Utsubo;
        ankou Ankou;
        hasami Hasami;
        lure Lure;
        fish[] f = new fish[4];
        int point = 0;
        int iwashipoint = 0;
        int utsubopoint = 0;
        int ankoupoint = 0;
        int iwashicount = 0;
        int utsubocount = 0;
        int ankoucount = 0;

        public Form1()
        {
            InitializeComponent();

            //ちらつき防止
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            Iwashi = new iwashi(fishingGame.Properties.Resources.iwashi
                                , 0, 30, 100, 50, this.ClientSize.Width, 20);
            Utsubo = new utsubo(fishingGame.Properties.Resources.utubo
                                , 0, 110, 150, 75, this.ClientSize.Width, 10);
            Ankou = new ankou(fishingGame.Properties.Resources.ankou
                                , 0, 190, 125, 65, this.ClientSize.Width, 15);
            Hasami = new hasami(fishingGame.Properties.Resources.hachami
                                , 0, 270, 100, 50, this.ClientSize.Width, 10);
            f[0] = Iwashi;
            f[1] = Utsubo;
            f[2] = Ankou;
            f[3] = Hasami;
            Iwashi = null;
            Utsubo = null;
            Ankou = null;
            Hasami = null;

            Lure = new lure(fishingGame.Properties.Resources.lure_bug, 100, 100, 50, 50, 1);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                f[i].disp(e.Graphics);
            }

            Lure.disp(e.Graphics);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                f[i].move();
                if (f[i].eat(Lure.mKind, Lure.mX, Lure.mY, Lure.mW, Lure.mH))
                {
                    point = f[i].point(point);
                    labelPoint.Text = point.ToString();
                    f[i].reset();
                    switch(i)
                    {
                        case 0:
                            iwashicount += 1;
                            iwashipoint += 10;
                            break;
                        case 1:
                            utsubocount += 1;
                            utsubopoint += 15;
                            break;
                        case 2:
                            ankoucount += 1;
                            ankoupoint += 20;
                            break;
                    }
                }
            }
            f[3].move();
            if (f[3].eat(Lure.mKind, Lure.mX, Lure.mY, Lure.mW, Lure.mH))
            {
                f[3].reset();
                timer1.Stop();
                panelGameOver.Visible = true;
                panelGameOver.Enabled = true;
                label4.Text = point.ToString();
            }

            Invalidate();//更新する
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Lure.change(1);
            }
            else if (e.KeyCode == Keys.F2)
            {
                Lure.change(2);
            }
            else if (e.KeyCode == Keys.Space)
            {
                timer1.Stop();
                panelMenu.Visible = true;
                panelMenu.Enabled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else
            {
                Lure.move(e.KeyCode);
            }

            Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panelMenu.Visible = false;
            panelMenu.Enabled = false;
            this.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ButtonSyuuryou_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSyousai_Click(object sender, EventArgs e)
        {
            panelSyousai.Visible = true;
            panelSyousai.Enabled = true;
            panelGameOver.Visible = false;
            panelGameOver.Enabled = false;
            labelIwashi.Text = iwashicount.ToString();
            labelUtsubo.Text = utsubocount.ToString();
            labelAnkou.Text = ankoucount.ToString();
            labelIwashiPoint.Text = iwashipoint.ToString();
            labelUtsuboPoint.Text = utsubopoint.ToString();
            labelAnkouPoint.Text = ankoupoint.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panelSyousai.Visible = false;
            panelSyousai.Enabled = false;
            panelGameOver.Visible = true;
            panelGameOver.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            f[3].speed();
        }
    }
}
