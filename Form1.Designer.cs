﻿namespace KesselRun
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
            this.UdShip = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWager = new System.Windows.Forms.Button();
            this.RbWatto = new System.Windows.Forms.RadioButton();
            this.RbSnoke = new System.Windows.Forms.RadioButton();
            this.RbJubba = new System.Windows.Forms.RadioButton();
            this.RbCreedo = new System.Windows.Forms.RadioButton();
            this.lblWagerName = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblWattoCash = new System.Windows.Forms.Label();
            this.lblSnokeCash = new System.Windows.Forms.Label();
            this.lblJubbaCash = new System.Windows.Forms.Label();
            this.lblCreedoCash = new System.Windows.Forms.Label();
            this.lblShipNumber = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.SystemColors.Control;
            this.Pb1.BackgroundImage = global::KesselRun.Resource1.Millenium_Falcon_920x518;
            this.Pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb1.Location = new System.Drawing.Point(6, 3);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(100, 79);
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.BackgroundImage = global::KesselRun.Resource1.Scimitar_BF2;
            this.Pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb2.Location = new System.Drawing.Point(6, 88);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(100, 79);
            this.Pb2.TabIndex = 1;
            this.Pb2.TabStop = false;
            // 
            // Pb3
            // 
            this.Pb3.BackgroundImage = global::KesselRun.Resource1.Slave_1;
            this.Pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb3.Location = new System.Drawing.Point(6, 173);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(100, 79);
            this.Pb3.TabIndex = 2;
            this.Pb3.TabStop = false;
            // 
            // Pb4
            // 
            this.Pb4.BackgroundImage = global::KesselRun.Resource1._68_960x600f;
            this.Pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb4.Location = new System.Drawing.Point(6, 272);
            this.Pb4.Name = "Pb4";
            this.Pb4.Size = new System.Drawing.Size(100, 79);
            this.Pb4.TabIndex = 3;
            this.Pb4.TabStop = false;
            // 
            // UdBet
            // 
            this.UdBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UdBet.Location = new System.Drawing.Point(599, 103);
            this.UdBet.Name = "UdBet";
            this.UdBet.Size = new System.Drawing.Size(120, 26);
            this.UdBet.TabIndex = 4;
            this.UdBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // UdShip
            // 
            this.UdShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UdShip.Location = new System.Drawing.Point(599, 181);
            this.UdShip.Name = "UdShip";
            this.UdShip.Size = new System.Drawing.Size(120, 26);
            this.UdShip.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1000, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(997, 175);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnWager
            // 
            this.btnWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWager.Location = new System.Drawing.Point(997, 101);
            this.btnWager.Name = "btnWager";
            this.btnWager.Size = new System.Drawing.Size(75, 36);
            this.btnWager.TabIndex = 8;
            this.btnWager.Text = "Wager";
            this.btnWager.UseVisualStyleBackColor = true;
            this.btnWager.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // RbWatto
            // 
            this.RbWatto.AutoSize = true;
            this.RbWatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbWatto.Location = new System.Drawing.Point(17, 173);
            this.RbWatto.Name = "RbWatto";
            this.RbWatto.Size = new System.Drawing.Size(70, 24);
            this.RbWatto.TabIndex = 9;
            this.RbWatto.TabStop = true;
            this.RbWatto.Text = "Watto";
            this.RbWatto.UseVisualStyleBackColor = true;
            this.RbWatto.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbSnoke
            // 
            this.RbSnoke.AutoSize = true;
            this.RbSnoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSnoke.Location = new System.Drawing.Point(15, 127);
            this.RbSnoke.Name = "RbSnoke";
            this.RbSnoke.Size = new System.Drawing.Size(73, 24);
            this.RbSnoke.TabIndex = 10;
            this.RbSnoke.TabStop = true;
            this.RbSnoke.Text = "Snoke";
            this.RbSnoke.UseVisualStyleBackColor = true;
            this.RbSnoke.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbJubba
            // 
            this.RbJubba.AutoSize = true;
            this.RbJubba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbJubba.Location = new System.Drawing.Point(15, 86);
            this.RbJubba.Name = "RbJubba";
            this.RbJubba.Size = new System.Drawing.Size(71, 24);
            this.RbJubba.TabIndex = 11;
            this.RbJubba.TabStop = true;
            this.RbJubba.Text = "Jubba";
            this.RbJubba.UseVisualStyleBackColor = true;
            this.RbJubba.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbCreedo
            // 
            this.RbCreedo.AutoSize = true;
            this.RbCreedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCreedo.Location = new System.Drawing.Point(12, 49);
            this.RbCreedo.Name = "RbCreedo";
            this.RbCreedo.Size = new System.Drawing.Size(79, 24);
            this.RbCreedo.TabIndex = 12;
            this.RbCreedo.TabStop = true;
            this.RbCreedo.Text = "Creedo";
            this.RbCreedo.UseVisualStyleBackColor = true;
            this.RbCreedo.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // lblWagerName
            // 
            this.lblWagerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblWagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWagerName.Location = new System.Drawing.Point(240, 23);
            this.lblWagerName.Name = "lblWagerName";
            this.lblWagerName.Size = new System.Drawing.Size(303, 223);
            this.lblWagerName.TabIndex = 13;
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(1133, 31);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(140, 66);
            this.lblWinner.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::KesselRun.Resource1._1;
            this.splitContainer1.Panel1.Controls.Add(this.Pb1);
            this.splitContainer1.Panel1.Controls.Add(this.Pb4);
            this.splitContainer1.Panel1.Controls.Add(this.Pb2);
            this.splitContainer1.Panel1.Controls.Add(this.Pb3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblWattoCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblSnokeCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblJubbaCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblCreedoCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblShipNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lblCredits);
            this.splitContainer1.Panel2.Controls.Add(this.UdBet);
            this.splitContainer1.Panel2.Controls.Add(this.lblWinner);
            this.splitContainer1.Panel2.Controls.Add(this.btnWager);
            this.splitContainer1.Panel2.Controls.Add(this.UdShip);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.lblWagerName);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.RbCreedo);
            this.splitContainer1.Panel2.Controls.Add(this.RbWatto);
            this.splitContainer1.Panel2.Controls.Add(this.RbJubba);
            this.splitContainer1.Panel2.Controls.Add(this.RbSnoke);
            this.splitContainer1.Size = new System.Drawing.Size(1318, 695);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 15;
            // 
            // lblWattoCash
            // 
            this.lblWattoCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWattoCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWattoCash.Location = new System.Drawing.Point(97, 175);
            this.lblWattoCash.Name = "lblWattoCash";
            this.lblWattoCash.Size = new System.Drawing.Size(100, 23);
            this.lblWattoCash.TabIndex = 20;
            this.lblWattoCash.Text = "label4";
            // 
            // lblSnokeCash
            // 
            this.lblSnokeCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSnokeCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnokeCash.Location = new System.Drawing.Point(97, 139);
            this.lblSnokeCash.Name = "lblSnokeCash";
            this.lblSnokeCash.Size = new System.Drawing.Size(100, 23);
            this.lblSnokeCash.TabIndex = 19;
            this.lblSnokeCash.Text = "label3";
            // 
            // lblJubbaCash
            // 
            this.lblJubbaCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblJubbaCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJubbaCash.Location = new System.Drawing.Point(97, 88);
            this.lblJubbaCash.Name = "lblJubbaCash";
            this.lblJubbaCash.Size = new System.Drawing.Size(100, 23);
            this.lblJubbaCash.TabIndex = 18;
            this.lblJubbaCash.Text = "label2";
            // 
            // lblCreedoCash
            // 
            this.lblCreedoCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCreedoCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreedoCash.Location = new System.Drawing.Point(97, 51);
            this.lblCreedoCash.Name = "lblCreedoCash";
            this.lblCreedoCash.Size = new System.Drawing.Size(137, 23);
            this.lblCreedoCash.TabIndex = 17;
            this.lblCreedoCash.Text = "label1";
            // 
            // lblShipNumber
            // 
            this.lblShipNumber.AutoSize = true;
            this.lblShipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipNumber.Location = new System.Drawing.Point(599, 143);
            this.lblShipNumber.Name = "lblShipNumber";
            this.lblShipNumber.Size = new System.Drawing.Size(97, 20);
            this.lblShipNumber.TabIndex = 16;
            this.lblShipNumber.Text = "ShipNumber";
            // 
            // lblCredits
            // 
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(596, 74);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(123, 23);
            this.lblCredits.TabIndex = 15;
            this.lblCredits.Text = "Galactic Credits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 695);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdShip)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.PictureBox Pb4;
        private System.Windows.Forms.NumericUpDown UdBet;
        private System.Windows.Forms.NumericUpDown UdShip;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWager;
        private System.Windows.Forms.RadioButton RbWatto;
        private System.Windows.Forms.RadioButton RbSnoke;
        private System.Windows.Forms.RadioButton RbJubba;
        private System.Windows.Forms.RadioButton RbCreedo;
        private System.Windows.Forms.Label lblWagerName;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblShipNumber;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblWattoCash;
        private System.Windows.Forms.Label lblSnokeCash;
        private System.Windows.Forms.Label lblJubbaCash;
        private System.Windows.Forms.Label lblCreedoCash;
    }
}

