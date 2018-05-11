namespace BattleCity.NET
{
    partial class FBattleScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPlayer4 = new System.Windows.Forms.GroupBox();
            this.pbPlayer4Reload = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pbTank4Image = new System.Windows.Forms.PictureBox();
            this.lPlayer4Condition = new System.Windows.Forms.Label();
            this.lPlayer4Hits = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbPlayer4Health = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.gbPlayer3 = new System.Windows.Forms.GroupBox();
            this.pbPlayer3Reload = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pbTank3Image = new System.Windows.Forms.PictureBox();
            this.lPlayer3Condition = new System.Windows.Forms.Label();
            this.lPlayer3Hits = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbPlayer3Health = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.pbPlayer2Reload = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.pbTank2Image = new System.Windows.Forms.PictureBox();
            this.lPlayer2Condition = new System.Windows.Forms.Label();
            this.lPlayer2Hits = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPlayer2Health = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.pbPlayer1Reload = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.pbTank1Image = new System.Windows.Forms.PictureBox();
            this.lPlayer1Condition = new System.Windows.Forms.Label();
            this.lPlayer1Hits = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPlayer1Health = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbPlayer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank4Image)).BeginInit();
            this.gbPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank3Image)).BeginInit();
            this.gbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank2Image)).BeginInit();
            this.gbPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank1Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.gbPlayer4);
            this.panel1.Controls.Add(this.gbPlayer3);
            this.panel1.Controls.Add(this.gbPlayer2);
            this.panel1.Controls.Add(this.gbPlayer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(640, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 480);
            this.panel1.TabIndex = 0;
            // 
            // gbPlayer4
            // 
            this.gbPlayer4.Controls.Add(this.pbPlayer4Reload);
            this.gbPlayer4.Controls.Add(this.label3);
            this.gbPlayer4.Controls.Add(this.pbTank4Image);
            this.gbPlayer4.Controls.Add(this.lPlayer4Condition);
            this.gbPlayer4.Controls.Add(this.lPlayer4Hits);
            this.gbPlayer4.Controls.Add(this.label13);
            this.gbPlayer4.Controls.Add(this.pbPlayer4Health);
            this.gbPlayer4.Controls.Add(this.label14);
            this.gbPlayer4.Location = new System.Drawing.Point(0, 360);
            this.gbPlayer4.Name = "gbPlayer4";
            this.gbPlayer4.Size = new System.Drawing.Size(200, 120);
            this.gbPlayer4.TabIndex = 0;
            this.gbPlayer4.TabStop = false;
            this.gbPlayer4.Text = "Player4";
            this.gbPlayer4.Visible = false;
            // 
            // pbPlayer4Reload
            // 
            this.pbPlayer4Reload.Location = new System.Drawing.Point(61, 45);
            this.pbPlayer4Reload.Name = "pbPlayer4Reload";
            this.pbPlayer4Reload.Size = new System.Drawing.Size(133, 19);
            this.pbPlayer4Reload.Step = 1;
            this.pbPlayer4Reload.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reload";
            // 
            // pbTank4Image
            // 
            this.pbTank4Image.Location = new System.Drawing.Point(138, 67);
            this.pbTank4Image.Name = "pbTank4Image";
            this.pbTank4Image.Size = new System.Drawing.Size(50, 50);
            this.pbTank4Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank4Image.TabIndex = 5;
            this.pbTank4Image.TabStop = false;
            // 
            // lPlayer4Condition
            // 
            this.lPlayer4Condition.AutoSize = true;
            this.lPlayer4Condition.Location = new System.Drawing.Point(5, 100);
            this.lPlayer4Condition.Name = "lPlayer4Condition";
            this.lPlayer4Condition.Size = new System.Drawing.Size(48, 17);
            this.lPlayer4Condition.TabIndex = 4;
            this.lPlayer4Condition.Text = "NONE";
            // 
            // lPlayer4Hits
            // 
            this.lPlayer4Hits.AutoSize = true;
            this.lPlayer4Hits.Location = new System.Drawing.Point(50, 75);
            this.lPlayer4Hits.Name = "lPlayer4Hits";
            this.lPlayer4Hits.Size = new System.Drawing.Size(16, 17);
            this.lPlayer4Hits.TabIndex = 3;
            this.lPlayer4Hits.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Hits: ";
            // 
            // pbPlayer4Health
            // 
            this.pbPlayer4Health.Location = new System.Drawing.Point(61, 16);
            this.pbPlayer4Health.Name = "pbPlayer4Health";
            this.pbPlayer4Health.Size = new System.Drawing.Size(133, 23);
            this.pbPlayer4Health.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Health";
            // 
            // gbPlayer3
            // 
            this.gbPlayer3.Controls.Add(this.pbPlayer3Reload);
            this.gbPlayer3.Controls.Add(this.label4);
            this.gbPlayer3.Controls.Add(this.pbTank3Image);
            this.gbPlayer3.Controls.Add(this.lPlayer3Condition);
            this.gbPlayer3.Controls.Add(this.lPlayer3Hits);
            this.gbPlayer3.Controls.Add(this.label9);
            this.gbPlayer3.Controls.Add(this.pbPlayer3Health);
            this.gbPlayer3.Controls.Add(this.label10);
            this.gbPlayer3.Location = new System.Drawing.Point(0, 240);
            this.gbPlayer3.Name = "gbPlayer3";
            this.gbPlayer3.Size = new System.Drawing.Size(200, 120);
            this.gbPlayer3.TabIndex = 0;
            this.gbPlayer3.TabStop = false;
            this.gbPlayer3.Text = "Player3";
            this.gbPlayer3.Visible = false;
            // 
            // pbPlayer3Reload
            // 
            this.pbPlayer3Reload.Location = new System.Drawing.Point(61, 45);
            this.pbPlayer3Reload.Name = "pbPlayer3Reload";
            this.pbPlayer3Reload.Size = new System.Drawing.Size(133, 19);
            this.pbPlayer3Reload.Step = 1;
            this.pbPlayer3Reload.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reload";
            // 
            // pbTank3Image
            // 
            this.pbTank3Image.Location = new System.Drawing.Point(138, 67);
            this.pbTank3Image.Name = "pbTank3Image";
            this.pbTank3Image.Size = new System.Drawing.Size(50, 50);
            this.pbTank3Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank3Image.TabIndex = 5;
            this.pbTank3Image.TabStop = false;
            // 
            // lPlayer3Condition
            // 
            this.lPlayer3Condition.AutoSize = true;
            this.lPlayer3Condition.Location = new System.Drawing.Point(5, 100);
            this.lPlayer3Condition.Name = "lPlayer3Condition";
            this.lPlayer3Condition.Size = new System.Drawing.Size(48, 17);
            this.lPlayer3Condition.TabIndex = 4;
            this.lPlayer3Condition.Text = "NONE";
            // 
            // lPlayer3Hits
            // 
            this.lPlayer3Hits.AutoSize = true;
            this.lPlayer3Hits.Location = new System.Drawing.Point(50, 75);
            this.lPlayer3Hits.Name = "lPlayer3Hits";
            this.lPlayer3Hits.Size = new System.Drawing.Size(16, 17);
            this.lPlayer3Hits.TabIndex = 3;
            this.lPlayer3Hits.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hits: ";
            // 
            // pbPlayer3Health
            // 
            this.pbPlayer3Health.Location = new System.Drawing.Point(61, 16);
            this.pbPlayer3Health.Name = "pbPlayer3Health";
            this.pbPlayer3Health.Size = new System.Drawing.Size(133, 23);
            this.pbPlayer3Health.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Health";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.pbPlayer2Reload);
            this.gbPlayer2.Controls.Add(this.label7);
            this.gbPlayer2.Controls.Add(this.pbTank2Image);
            this.gbPlayer2.Controls.Add(this.lPlayer2Condition);
            this.gbPlayer2.Controls.Add(this.lPlayer2Hits);
            this.gbPlayer2.Controls.Add(this.label5);
            this.gbPlayer2.Controls.Add(this.pbPlayer2Health);
            this.gbPlayer2.Controls.Add(this.label6);
            this.gbPlayer2.Location = new System.Drawing.Point(0, 120);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(200, 120);
            this.gbPlayer2.TabIndex = 0;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player2";
            this.gbPlayer2.Visible = false;
            // 
            // pbPlayer2Reload
            // 
            this.pbPlayer2Reload.Location = new System.Drawing.Point(61, 45);
            this.pbPlayer2Reload.Name = "pbPlayer2Reload";
            this.pbPlayer2Reload.Size = new System.Drawing.Size(133, 19);
            this.pbPlayer2Reload.Step = 1;
            this.pbPlayer2Reload.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reload";
            // 
            // pbTank2Image
            // 
            this.pbTank2Image.Location = new System.Drawing.Point(138, 67);
            this.pbTank2Image.Name = "pbTank2Image";
            this.pbTank2Image.Size = new System.Drawing.Size(50, 50);
            this.pbTank2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank2Image.TabIndex = 5;
            this.pbTank2Image.TabStop = false;
            // 
            // lPlayer2Condition
            // 
            this.lPlayer2Condition.AutoSize = true;
            this.lPlayer2Condition.Location = new System.Drawing.Point(5, 100);
            this.lPlayer2Condition.Name = "lPlayer2Condition";
            this.lPlayer2Condition.Size = new System.Drawing.Size(48, 17);
            this.lPlayer2Condition.TabIndex = 4;
            this.lPlayer2Condition.Text = "NONE";
            // 
            // lPlayer2Hits
            // 
            this.lPlayer2Hits.AutoSize = true;
            this.lPlayer2Hits.Location = new System.Drawing.Point(50, 75);
            this.lPlayer2Hits.Name = "lPlayer2Hits";
            this.lPlayer2Hits.Size = new System.Drawing.Size(16, 17);
            this.lPlayer2Hits.TabIndex = 3;
            this.lPlayer2Hits.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hits: ";
            // 
            // pbPlayer2Health
            // 
            this.pbPlayer2Health.Location = new System.Drawing.Point(61, 16);
            this.pbPlayer2Health.Name = "pbPlayer2Health";
            this.pbPlayer2Health.Size = new System.Drawing.Size(133, 23);
            this.pbPlayer2Health.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Health";
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.pbPlayer1Reload);
            this.gbPlayer1.Controls.Add(this.label8);
            this.gbPlayer1.Controls.Add(this.pbTank1Image);
            this.gbPlayer1.Controls.Add(this.lPlayer1Condition);
            this.gbPlayer1.Controls.Add(this.lPlayer1Hits);
            this.gbPlayer1.Controls.Add(this.label2);
            this.gbPlayer1.Controls.Add(this.pbPlayer1Health);
            this.gbPlayer1.Controls.Add(this.label1);
            this.gbPlayer1.Location = new System.Drawing.Point(0, 0);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(200, 120);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player1";
            this.gbPlayer1.Visible = false;
            // 
            // pbPlayer1Reload
            // 
            this.pbPlayer1Reload.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbPlayer1Reload.Location = new System.Drawing.Point(61, 45);
            this.pbPlayer1Reload.Name = "pbPlayer1Reload";
            this.pbPlayer1Reload.Size = new System.Drawing.Size(133, 19);
            this.pbPlayer1Reload.Step = 1;
            this.pbPlayer1Reload.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Reload";
            // 
            // pbTank1Image
            // 
            this.pbTank1Image.Location = new System.Drawing.Point(138, 67);
            this.pbTank1Image.Name = "pbTank1Image";
            this.pbTank1Image.Size = new System.Drawing.Size(50, 50);
            this.pbTank1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank1Image.TabIndex = 5;
            this.pbTank1Image.TabStop = false;
            // 
            // lPlayer1Condition
            // 
            this.lPlayer1Condition.AutoSize = true;
            this.lPlayer1Condition.Location = new System.Drawing.Point(5, 100);
            this.lPlayer1Condition.Name = "lPlayer1Condition";
            this.lPlayer1Condition.Size = new System.Drawing.Size(48, 17);
            this.lPlayer1Condition.TabIndex = 4;
            this.lPlayer1Condition.Text = "NONE";
            // 
            // lPlayer1Hits
            // 
            this.lPlayer1Hits.AutoSize = true;
            this.lPlayer1Hits.Location = new System.Drawing.Point(50, 75);
            this.lPlayer1Hits.Name = "lPlayer1Hits";
            this.lPlayer1Hits.Size = new System.Drawing.Size(16, 17);
            this.lPlayer1Hits.TabIndex = 3;
            this.lPlayer1Hits.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hits: ";
            // 
            // pbPlayer1Health
            // 
            this.pbPlayer1Health.Location = new System.Drawing.Point(61, 16);
            this.pbPlayer1Health.Name = "pbPlayer1Health";
            this.pbPlayer1Health.Size = new System.Drawing.Size(133, 23);
            this.pbPlayer1Health.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FBattleScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FBattleScreen";
            this.Text = "BattleCity.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBattleScreen_FormClosing);
            this.panel1.ResumeLayout(false);
            this.gbPlayer4.ResumeLayout(false);
            this.gbPlayer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank4Image)).EndInit();
            this.gbPlayer3.ResumeLayout(false);
            this.gbPlayer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank3Image)).EndInit();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank2Image)).EndInit();
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank1Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPlayer4;
        private System.Windows.Forms.Label lPlayer4Condition;
        private System.Windows.Forms.Label lPlayer4Hits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar pbPlayer4Health;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbPlayer3;
        private System.Windows.Forms.Label lPlayer3Condition;
        private System.Windows.Forms.Label lPlayer3Hits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pbPlayer3Health;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Label lPlayer2Condition;
        private System.Windows.Forms.Label lPlayer2Hits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbPlayer2Health;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.Label lPlayer1Condition;
        private System.Windows.Forms.Label lPlayer1Hits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbPlayer1Health;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbTank4Image;
        private System.Windows.Forms.PictureBox pbTank3Image;
        private System.Windows.Forms.PictureBox pbTank2Image;
        private System.Windows.Forms.PictureBox pbTank1Image;
        private System.Windows.Forms.ProgressBar pbPlayer4Reload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbPlayer3Reload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbPlayer2Reload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbPlayer1Reload;
        private System.Windows.Forms.Label label8;
    }
}