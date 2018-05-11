namespace BattleCity.NET
{
    partial class Form1
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
            this.bNext = new System.Windows.Forms.Button();
            this.cbDLLs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.gbTank1 = new System.Windows.Forms.GroupBox();
            this.pbTank1Image = new System.Windows.Forms.PictureBox();
            this.bTank1Remove = new System.Windows.Forms.Button();
            this.lTank1DLL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTank2 = new System.Windows.Forms.GroupBox();
            this.pbTank2Image = new System.Windows.Forms.PictureBox();
            this.bTank2Remove = new System.Windows.Forms.Button();
            this.lTank2DLL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTank3 = new System.Windows.Forms.GroupBox();
            this.pbTank3Image = new System.Windows.Forms.PictureBox();
            this.bTank3Remove = new System.Windows.Forms.Button();
            this.lTank3DLL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbTank4 = new System.Windows.Forms.GroupBox();
            this.pbTank4Image = new System.Windows.Forms.PictureBox();
            this.bTank4Remove = new System.Windows.Forms.Button();
            this.lTank4DLL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbImage = new System.Windows.Forms.ComboBox();
            this.gbTank1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank1Image)).BeginInit();
            this.gbTank2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank2Image)).BeginInit();
            this.gbTank3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank3Image)).BeginInit();
            this.gbTank4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank4Image)).BeginInit();
            this.SuspendLayout();
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(393, 389);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 0;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // cbDLLs
            // 
            this.cbDLLs.FormattingEnabled = true;
            this.cbDLLs.Location = new System.Drawing.Point(50, 9);
            this.cbDLLs.Name = "cbDLLs";
            this.cbDLLs.Size = new System.Drawing.Size(136, 24);
            this.cbDLLs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DLL";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(393, 9);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // gbTank1
            // 
            this.gbTank1.Controls.Add(this.pbTank1Image);
            this.gbTank1.Controls.Add(this.bTank1Remove);
            this.gbTank1.Controls.Add(this.lTank1DLL);
            this.gbTank1.Controls.Add(this.label2);
            this.gbTank1.Location = new System.Drawing.Point(10, 39);
            this.gbTank1.Name = "gbTank1";
            this.gbTank1.Size = new System.Drawing.Size(458, 80);
            this.gbTank1.TabIndex = 7;
            this.gbTank1.TabStop = false;
            this.gbTank1.Text = "Player1";
            this.gbTank1.Visible = false;
            // 
            // pbTank1Image
            // 
            this.pbTank1Image.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbTank1Image.Location = new System.Drawing.Point(388, 9);
            this.pbTank1Image.Name = "pbTank1Image";
            this.pbTank1Image.Size = new System.Drawing.Size(64, 64);
            this.pbTank1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank1Image.TabIndex = 3;
            this.pbTank1Image.TabStop = false;
            // 
            // bTank1Remove
            // 
            this.bTank1Remove.Location = new System.Drawing.Point(6, 50);
            this.bTank1Remove.Name = "bTank1Remove";
            this.bTank1Remove.Size = new System.Drawing.Size(75, 23);
            this.bTank1Remove.TabIndex = 2;
            this.bTank1Remove.Text = "Remove";
            this.bTank1Remove.UseVisualStyleBackColor = true;
            this.bTank1Remove.Click += new System.EventHandler(this.bTank1Remove_Click);
            // 
            // lTank1DLL
            // 
            this.lTank1DLL.AutoSize = true;
            this.lTank1DLL.Location = new System.Drawing.Point(57, 18);
            this.lTank1DLL.Name = "lTank1DLL";
            this.lTank1DLL.Size = new System.Drawing.Size(80, 17);
            this.lTank1DLL.TabIndex = 1;
            this.lTank1DLL.Text = "Wrong DLL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "DLL: ";
            // 
            // gbTank2
            // 
            this.gbTank2.Controls.Add(this.pbTank2Image);
            this.gbTank2.Controls.Add(this.bTank2Remove);
            this.gbTank2.Controls.Add(this.lTank2DLL);
            this.gbTank2.Controls.Add(this.label4);
            this.gbTank2.Location = new System.Drawing.Point(10, 125);
            this.gbTank2.Name = "gbTank2";
            this.gbTank2.Size = new System.Drawing.Size(458, 80);
            this.gbTank2.TabIndex = 7;
            this.gbTank2.TabStop = false;
            this.gbTank2.Text = "Player2";
            this.gbTank2.Visible = false;
            // 
            // pbTank2Image
            // 
            this.pbTank2Image.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbTank2Image.Location = new System.Drawing.Point(388, 9);
            this.pbTank2Image.Name = "pbTank2Image";
            this.pbTank2Image.Size = new System.Drawing.Size(64, 64);
            this.pbTank2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank2Image.TabIndex = 3;
            this.pbTank2Image.TabStop = false;
            // 
            // bTank2Remove
            // 
            this.bTank2Remove.Location = new System.Drawing.Point(6, 50);
            this.bTank2Remove.Name = "bTank2Remove";
            this.bTank2Remove.Size = new System.Drawing.Size(75, 23);
            this.bTank2Remove.TabIndex = 2;
            this.bTank2Remove.Text = "Remove";
            this.bTank2Remove.UseVisualStyleBackColor = true;
            this.bTank2Remove.Click += new System.EventHandler(this.bTank2Remove_Click);
            // 
            // lTank2DLL
            // 
            this.lTank2DLL.AutoSize = true;
            this.lTank2DLL.Location = new System.Drawing.Point(57, 18);
            this.lTank2DLL.Name = "lTank2DLL";
            this.lTank2DLL.Size = new System.Drawing.Size(80, 17);
            this.lTank2DLL.TabIndex = 1;
            this.lTank2DLL.Text = "Wrong DLL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DLL: ";
            // 
            // gbTank3
            // 
            this.gbTank3.Controls.Add(this.pbTank3Image);
            this.gbTank3.Controls.Add(this.bTank3Remove);
            this.gbTank3.Controls.Add(this.lTank3DLL);
            this.gbTank3.Controls.Add(this.label7);
            this.gbTank3.Location = new System.Drawing.Point(10, 211);
            this.gbTank3.Name = "gbTank3";
            this.gbTank3.Size = new System.Drawing.Size(458, 80);
            this.gbTank3.TabIndex = 7;
            this.gbTank3.TabStop = false;
            this.gbTank3.Text = "Player3";
            this.gbTank3.Visible = false;
            // 
            // pbTank3Image
            // 
            this.pbTank3Image.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbTank3Image.Location = new System.Drawing.Point(388, 9);
            this.pbTank3Image.Name = "pbTank3Image";
            this.pbTank3Image.Size = new System.Drawing.Size(64, 64);
            this.pbTank3Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank3Image.TabIndex = 3;
            this.pbTank3Image.TabStop = false;
            // 
            // bTank3Remove
            // 
            this.bTank3Remove.Location = new System.Drawing.Point(6, 50);
            this.bTank3Remove.Name = "bTank3Remove";
            this.bTank3Remove.Size = new System.Drawing.Size(75, 23);
            this.bTank3Remove.TabIndex = 2;
            this.bTank3Remove.Text = "Remove";
            this.bTank3Remove.UseVisualStyleBackColor = true;
            this.bTank3Remove.Click += new System.EventHandler(this.bTank3Remove_Click);
            // 
            // lTank3DLL
            // 
            this.lTank3DLL.AutoSize = true;
            this.lTank3DLL.Location = new System.Drawing.Point(57, 18);
            this.lTank3DLL.Name = "lTank3DLL";
            this.lTank3DLL.Size = new System.Drawing.Size(80, 17);
            this.lTank3DLL.TabIndex = 1;
            this.lTank3DLL.Text = "Wrong DLL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "DLL: ";
            // 
            // gbTank4
            // 
            this.gbTank4.Controls.Add(this.pbTank4Image);
            this.gbTank4.Controls.Add(this.bTank4Remove);
            this.gbTank4.Controls.Add(this.lTank4DLL);
            this.gbTank4.Controls.Add(this.label9);
            this.gbTank4.Location = new System.Drawing.Point(10, 297);
            this.gbTank4.Name = "gbTank4";
            this.gbTank4.Size = new System.Drawing.Size(458, 80);
            this.gbTank4.TabIndex = 7;
            this.gbTank4.TabStop = false;
            this.gbTank4.Text = "Player4";
            this.gbTank4.Visible = false;
            // 
            // pbTank4Image
            // 
            this.pbTank4Image.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbTank4Image.Location = new System.Drawing.Point(388, 9);
            this.pbTank4Image.Name = "pbTank4Image";
            this.pbTank4Image.Size = new System.Drawing.Size(64, 64);
            this.pbTank4Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTank4Image.TabIndex = 3;
            this.pbTank4Image.TabStop = false;
            // 
            // bTank4Remove
            // 
            this.bTank4Remove.Location = new System.Drawing.Point(6, 50);
            this.bTank4Remove.Name = "bTank4Remove";
            this.bTank4Remove.Size = new System.Drawing.Size(75, 23);
            this.bTank4Remove.TabIndex = 2;
            this.bTank4Remove.Text = "Remove";
            this.bTank4Remove.UseVisualStyleBackColor = true;
            this.bTank4Remove.Click += new System.EventHandler(this.bTank4Remove_Click);
            // 
            // lTank4DLL
            // 
            this.lTank4DLL.AutoSize = true;
            this.lTank4DLL.Location = new System.Drawing.Point(57, 18);
            this.lTank4DLL.Name = "lTank4DLL";
            this.lTank4DLL.Size = new System.Drawing.Size(80, 17);
            this.lTank4DLL.TabIndex = 1;
            this.lTank4DLL.Text = "Wrong DLL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "DLL: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skin";
            // 
            // cbImage
            // 
            this.cbImage.FormattingEnabled = true;
            this.cbImage.Location = new System.Drawing.Point(229, 8);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(154, 24);
            this.cbImage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 420);
            this.Controls.Add(this.cbImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbTank4);
            this.Controls.Add(this.gbTank3);
            this.Controls.Add(this.gbTank2);
            this.Controls.Add(this.gbTank1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDLLs);
            this.Controls.Add(this.bNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game Setup";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbTank1.ResumeLayout(false);
            this.gbTank1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank1Image)).EndInit();
            this.gbTank2.ResumeLayout(false);
            this.gbTank2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank2Image)).EndInit();
            this.gbTank3.ResumeLayout(false);
            this.gbTank3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank3Image)).EndInit();
            this.gbTank4.ResumeLayout(false);
            this.gbTank4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTank4Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.ComboBox cbDLLs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox gbTank1;
        private System.Windows.Forms.PictureBox pbTank1Image;
        private System.Windows.Forms.Button bTank1Remove;
        private System.Windows.Forms.Label lTank1DLL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTank2;
        private System.Windows.Forms.PictureBox pbTank2Image;
        private System.Windows.Forms.Button bTank2Remove;
        private System.Windows.Forms.Label lTank2DLL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTank3;
        private System.Windows.Forms.PictureBox pbTank3Image;
        private System.Windows.Forms.Button bTank3Remove;
        private System.Windows.Forms.Label lTank3DLL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbTank4;
        private System.Windows.Forms.PictureBox pbTank4Image;
        private System.Windows.Forms.Button bTank4Remove;
        private System.Windows.Forms.Label lTank4DLL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbImage;
    }
}

