namespace fishingGame
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPoint = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSyuuryou = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSyousai = new System.Windows.Forms.Button();
            this.panelSyousai = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIwashi = new System.Windows.Forms.Label();
            this.labelUtsubo = new System.Windows.Forms.Label();
            this.labelAnkou = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelIwashiPoint = new System.Windows.Forms.Label();
            this.labelUtsuboPoint = new System.Windows.Forms.Label();
            this.labelAnkouPoint = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            this.panelSyousai.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("メイリオ", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPoint.Location = new System.Drawing.Point(437, 9);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(50, 60);
            this.labelPoint.TabIndex = 0;
            this.labelPoint.Text = "0";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Enabled = false;
            this.panelMenu.Location = new System.Drawing.Point(215, 133);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(531, 288);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "ポーズメニュー";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "終了";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "再開";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.White;
            this.panelGameOver.Controls.Add(this.buttonSyousai);
            this.panelGameOver.Controls.Add(this.buttonSyuuryou);
            this.panelGameOver.Controls.Add(this.buttonRestart);
            this.panelGameOver.Controls.Add(this.label4);
            this.panelGameOver.Controls.Add(this.label3);
            this.panelGameOver.Controls.Add(this.label2);
            this.panelGameOver.Enabled = false;
            this.panelGameOver.Location = new System.Drawing.Point(215, 133);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(531, 288);
            this.panelGameOver.TabIndex = 2;
            this.panelGameOver.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(146, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "ゲームオーバー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(126, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "得点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(324, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 2;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(25, 207);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(144, 52);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "最初から";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // buttonSyuuryou
            // 
            this.buttonSyuuryou.Location = new System.Drawing.Point(357, 207);
            this.buttonSyuuryou.Name = "buttonSyuuryou";
            this.buttonSyuuryou.Size = new System.Drawing.Size(144, 52);
            this.buttonSyuuryou.TabIndex = 4;
            this.buttonSyuuryou.Text = "終了";
            this.buttonSyuuryou.UseVisualStyleBackColor = true;
            this.buttonSyuuryou.Click += new System.EventHandler(this.ButtonSyuuryou_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "最初から";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonSyousai
            // 
            this.buttonSyousai.Location = new System.Drawing.Point(192, 207);
            this.buttonSyousai.Name = "buttonSyousai";
            this.buttonSyousai.Size = new System.Drawing.Size(144, 52);
            this.buttonSyousai.TabIndex = 5;
            this.buttonSyousai.Text = "詳細結果";
            this.buttonSyousai.UseVisualStyleBackColor = true;
            this.buttonSyousai.Click += new System.EventHandler(this.ButtonSyousai_Click);
            // 
            // panelSyousai
            // 
            this.panelSyousai.BackColor = System.Drawing.Color.White;
            this.panelSyousai.Controls.Add(this.button4);
            this.panelSyousai.Controls.Add(this.labelIwashiPoint);
            this.panelSyousai.Controls.Add(this.labelUtsuboPoint);
            this.panelSyousai.Controls.Add(this.labelAnkouPoint);
            this.panelSyousai.Controls.Add(this.label20);
            this.panelSyousai.Controls.Add(this.label19);
            this.panelSyousai.Controls.Add(this.label18);
            this.panelSyousai.Controls.Add(this.label17);
            this.panelSyousai.Controls.Add(this.label16);
            this.panelSyousai.Controls.Add(this.label15);
            this.panelSyousai.Controls.Add(this.label14);
            this.panelSyousai.Controls.Add(this.label13);
            this.panelSyousai.Controls.Add(this.label12);
            this.panelSyousai.Controls.Add(this.label11);
            this.panelSyousai.Controls.Add(this.label10);
            this.panelSyousai.Controls.Add(this.label9);
            this.panelSyousai.Controls.Add(this.label8);
            this.panelSyousai.Controls.Add(this.labelAnkou);
            this.panelSyousai.Controls.Add(this.labelUtsubo);
            this.panelSyousai.Controls.Add(this.labelIwashi);
            this.panelSyousai.Controls.Add(this.label7);
            this.panelSyousai.Controls.Add(this.label6);
            this.panelSyousai.Controls.Add(this.label5);
            this.panelSyousai.Enabled = false;
            this.panelSyousai.Location = new System.Drawing.Point(215, 133);
            this.panelSyousai.Name = "panelSyousai";
            this.panelSyousai.Size = new System.Drawing.Size(531, 288);
            this.panelSyousai.TabIndex = 3;
            this.panelSyousai.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "イワシ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "ウツボ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "アンコウ";
            // 
            // labelIwashi
            // 
            this.labelIwashi.AutoSize = true;
            this.labelIwashi.Location = new System.Drawing.Point(167, 84);
            this.labelIwashi.Name = "labelIwashi";
            this.labelIwashi.Size = new System.Drawing.Size(52, 18);
            this.labelIwashi.TabIndex = 3;
            this.labelIwashi.Text = "label8";
            // 
            // labelUtsubo
            // 
            this.labelUtsubo.AutoSize = true;
            this.labelUtsubo.Location = new System.Drawing.Point(167, 128);
            this.labelUtsubo.Name = "labelUtsubo";
            this.labelUtsubo.Size = new System.Drawing.Size(52, 18);
            this.labelUtsubo.TabIndex = 5;
            this.labelUtsubo.Text = "label9";
            // 
            // labelAnkou
            // 
            this.labelAnkou.AutoSize = true;
            this.labelAnkou.Location = new System.Drawing.Point(167, 172);
            this.labelAnkou.Name = "labelAnkou";
            this.labelAnkou.Size = new System.Drawing.Size(61, 18);
            this.labelAnkou.TabIndex = 6;
            this.labelAnkou.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(33, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "魚の種類";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(151, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "釣った数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(274, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "ポイント";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(399, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "得点";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "×";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "×";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "×";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(275, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(275, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "15";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(275, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 18);
            this.label17.TabIndex = 16;
            this.label17.Text = "20";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(343, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 18);
            this.label18.TabIndex = 17;
            this.label18.Text = "＝";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(343, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 18);
            this.label19.TabIndex = 18;
            this.label19.Text = "＝";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(343, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 18);
            this.label20.TabIndex = 19;
            this.label20.Text = "＝";
            // 
            // labelIwashiPoint
            // 
            this.labelIwashiPoint.AutoSize = true;
            this.labelIwashiPoint.Location = new System.Drawing.Point(404, 84);
            this.labelIwashiPoint.Name = "labelIwashiPoint";
            this.labelIwashiPoint.Size = new System.Drawing.Size(61, 18);
            this.labelIwashiPoint.TabIndex = 4;
            this.labelIwashiPoint.Text = "label21";
            // 
            // labelUtsuboPoint
            // 
            this.labelUtsuboPoint.AutoSize = true;
            this.labelUtsuboPoint.Location = new System.Drawing.Point(404, 128);
            this.labelUtsuboPoint.Name = "labelUtsuboPoint";
            this.labelUtsuboPoint.Size = new System.Drawing.Size(61, 18);
            this.labelUtsuboPoint.TabIndex = 5;
            this.labelUtsuboPoint.Text = "label22";
            // 
            // labelAnkouPoint
            // 
            this.labelAnkouPoint.AutoSize = true;
            this.labelAnkouPoint.Location = new System.Drawing.Point(404, 172);
            this.labelAnkouPoint.Name = "labelAnkouPoint";
            this.labelAnkouPoint.Size = new System.Drawing.Size(61, 18);
            this.labelAnkouPoint.TabIndex = 6;
            this.labelAnkouPoint.Text = "label23";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "戻る";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panelSyousai);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.labelPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "fishing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            this.panelSyousai.ResumeLayout(false);
            this.panelSyousai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSyuuryou;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSyousai;
        private System.Windows.Forms.Panel panelSyousai;
        private System.Windows.Forms.Label labelIwashi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAnkou;
        private System.Windows.Forms.Label labelUtsubo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelIwashiPoint;
        private System.Windows.Forms.Label labelUtsuboPoint;
        private System.Windows.Forms.Label labelAnkouPoint;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer2;
    }
}

