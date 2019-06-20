namespace KesselRun
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
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.Pb4 = new System.Windows.Forms.PictureBox();
            this.UdBet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWager = new System.Windows.Forms.Button();
            this.RbWatto = new System.Windows.Forms.RadioButton();
            this.RbSnoke = new System.Windows.Forms.RadioButton();
            this.RbJubba = new System.Windows.Forms.RadioButton();
            this.RbCreedo = new System.Windows.Forms.RadioButton();
            this.lblWagerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.Transparent;
            this.Pb1.BackgroundImage = global::KesselRun.Resource1.Millenium_Falcon_920x518;
            this.Pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb1.Location = new System.Drawing.Point(12, 12);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(101, 79);
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.BackgroundImage = global::KesselRun.Resource1.Scimitar_BF2;
            this.Pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb2.Location = new System.Drawing.Point(12, 106);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(101, 79);
            this.Pb2.TabIndex = 1;
            this.Pb2.TabStop = false;
            // 
            // Pb3
            // 
            this.Pb3.BackgroundImage = global::KesselRun.Resource1.Slave_1;
            this.Pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb3.Location = new System.Drawing.Point(12, 203);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(101, 79);
            this.Pb3.TabIndex = 2;
            this.Pb3.TabStop = false;
            // 
            // Pb4
            // 
            this.Pb4.BackgroundImage = global::KesselRun.Resource1._68_960x600f;
            this.Pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb4.Location = new System.Drawing.Point(12, 320);
            this.Pb4.Name = "Pb4";
            this.Pb4.Size = new System.Drawing.Size(101, 79);
            this.Pb4.TabIndex = 3;
            this.Pb4.TabStop = false;
            // 
            // UdBet
            // 
            this.UdBet.Location = new System.Drawing.Point(833, 345);
            this.UdBet.Name = "UdBet";
            this.UdBet.Size = new System.Drawing.Size(120, 20);
            this.UdBet.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(833, 399);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 463);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(153, 463);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnWager
            // 
            this.btnWager.Location = new System.Drawing.Point(281, 463);
            this.btnWager.Name = "btnWager";
            this.btnWager.Size = new System.Drawing.Size(75, 23);
            this.btnWager.TabIndex = 8;
            this.btnWager.Text = "Wager";
            this.btnWager.UseVisualStyleBackColor = true;
            this.btnWager.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // RbWatto
            // 
            this.RbWatto.AutoSize = true;
            this.RbWatto.Location = new System.Drawing.Point(397, 469);
            this.RbWatto.Name = "RbWatto";
            this.RbWatto.Size = new System.Drawing.Size(54, 17);
            this.RbWatto.TabIndex = 9;
            this.RbWatto.TabStop = true;
            this.RbWatto.Text = "Watto";
            this.RbWatto.UseVisualStyleBackColor = true;
            this.RbWatto.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbSnoke
            // 
            this.RbSnoke.AutoSize = true;
            this.RbSnoke.Location = new System.Drawing.Point(395, 423);
            this.RbSnoke.Name = "RbSnoke";
            this.RbSnoke.Size = new System.Drawing.Size(56, 17);
            this.RbSnoke.TabIndex = 10;
            this.RbSnoke.TabStop = true;
            this.RbSnoke.Text = "Snoke";
            this.RbSnoke.UseVisualStyleBackColor = true;
            // 
            // RbJubba
            // 
            this.RbJubba.AutoSize = true;
            this.RbJubba.Location = new System.Drawing.Point(395, 382);
            this.RbJubba.Name = "RbJubba";
            this.RbJubba.Size = new System.Drawing.Size(54, 17);
            this.RbJubba.TabIndex = 11;
            this.RbJubba.TabStop = true;
            this.RbJubba.Text = "Jubba";
            this.RbJubba.UseVisualStyleBackColor = true;
            // 
            // RbCreedo
            // 
            this.RbCreedo.AutoSize = true;
            this.RbCreedo.Location = new System.Drawing.Point(392, 345);
            this.RbCreedo.Name = "RbCreedo";
            this.RbCreedo.Size = new System.Drawing.Size(59, 17);
            this.RbCreedo.TabIndex = 12;
            this.RbCreedo.TabStop = true;
            this.RbCreedo.Text = "Creedo";
            this.RbCreedo.UseVisualStyleBackColor = true;
            // 
            // lblWagerName
            // 
            this.lblWagerName.Location = new System.Drawing.Point(466, 345);
            this.lblWagerName.Name = "lblWagerName";
            this.lblWagerName.Size = new System.Drawing.Size(238, 141);
            this.lblWagerName.TabIndex = 13;
            this.lblWagerName.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KesselRun.Resource1.starry_sky_night_stars_115042_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 617);
            this.Controls.Add(this.lblWagerName);
            this.Controls.Add(this.RbCreedo);
            this.Controls.Add(this.RbJubba);
            this.Controls.Add(this.RbSnoke);
            this.Controls.Add(this.RbWatto);
            this.Controls.Add(this.btnWager);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.UdBet);
            this.Controls.Add(this.Pb4);
            this.Controls.Add(this.Pb3);
            this.Controls.Add(this.Pb2);
            this.Controls.Add(this.Pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.PictureBox Pb4;
        private System.Windows.Forms.NumericUpDown UdBet;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWager;
        private System.Windows.Forms.RadioButton RbWatto;
        private System.Windows.Forms.RadioButton RbSnoke;
        private System.Windows.Forms.RadioButton RbJubba;
        private System.Windows.Forms.RadioButton RbCreedo;
        private System.Windows.Forms.Label lblWagerName;
    }
}

