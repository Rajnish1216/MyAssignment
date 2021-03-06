namespace TemplateAssisment
{
    partial class MainForm
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
            this.Exitthegame = new System.Windows.Forms.Button();
            this.AwayShootBTN = new System.Windows.Forms.PictureBox();
            this.SpinBTN = new System.Windows.Forms.PictureBox();
            this.ReloadButton = new System.Windows.Forms.PictureBox();
            this.Shoot = new System.Windows.Forms.PictureBox();
            this.Pict = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.lbl_Load = new System.Windows.Forms.Label();
            this.lbl_Spin = new System.Windows.Forms.Label();
            this.lbl_ShootHead = new System.Windows.Forms.Label();
            this.lbl_ShootAway = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AwayShootBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitthegame
            // 
            this.Exitthegame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exitthegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitthegame.ForeColor = System.Drawing.Color.Black;
            this.Exitthegame.Location = new System.Drawing.Point(22, 466);
            this.Exitthegame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exitthegame.Name = "Exitthegame";
            this.Exitthegame.Size = new System.Drawing.Size(177, 62);
            this.Exitthegame.TabIndex = 10;
            this.Exitthegame.Text = "Exit";
            this.Exitthegame.UseVisualStyleBackColor = false;
            this.Exitthegame.Click += new System.EventHandler(this.Exitthegame_Click);
            // 
            // AwayShootBTN
            // 
            this.AwayShootBTN.Image = global::TemplateAssisment.Properties.Resources.Away;
            this.AwayShootBTN.Location = new System.Drawing.Point(246, 269);
            this.AwayShootBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AwayShootBTN.Name = "AwayShootBTN";
            this.AwayShootBTN.Size = new System.Drawing.Size(134, 103);
            this.AwayShootBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwayShootBTN.TabIndex = 14;
            this.AwayShootBTN.TabStop = false;
            this.AwayShootBTN.Click += new System.EventHandler(this.AwayShootBTN_Click);
            // 
            // SpinBTN
            // 
            this.SpinBTN.Image = global::TemplateAssisment.Properties.Resources.Spin;
            this.SpinBTN.Location = new System.Drawing.Point(47, 269);
            this.SpinBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SpinBTN.Name = "SpinBTN";
            this.SpinBTN.Size = new System.Drawing.Size(119, 104);
            this.SpinBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpinBTN.TabIndex = 13;
            this.SpinBTN.TabStop = false;
            this.SpinBTN.Click += new System.EventHandler(this.SpinBTN_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Image = global::TemplateAssisment.Properties.Resources.Reloading;
            this.ReloadButton.Location = new System.Drawing.Point(47, 91);
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(119, 113);
            this.ReloadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadButton.TabIndex = 12;
            this.ReloadButton.TabStop = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // Shoot
            // 
            this.Shoot.ErrorImage = global::TemplateAssisment.Properties.Resources.icon_bullet_25;
            this.Shoot.Image = global::TemplateAssisment.Properties.Resources.icon_bullet_25;
            this.Shoot.Location = new System.Drawing.Point(246, 91);
            this.Shoot.Margin = new System.Windows.Forms.Padding(4);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(122, 114);
            this.Shoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shoot.TabIndex = 11;
            this.Shoot.TabStop = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // Pict
            // 
            this.Pict.BackColor = System.Drawing.Color.DarkKhaki;
            this.Pict.Image = global::TemplateAssisment.Properties.Resources.GunImage;
            this.Pict.Location = new System.Drawing.Point(461, 77);
            this.Pict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pict.Name = "Pict";
            this.Pict.Size = new System.Drawing.Size(600, 385);
            this.Pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict.TabIndex = 7;
            this.Pict.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox4.Location = new System.Drawing.Point(288, 11);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(502, 46);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "WELCOME TO RR GAME";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btn_PlayAgain.Location = new System.Drawing.Point(237, 466);
            this.btn_PlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(190, 62);
            this.btn_PlayAgain.TabIndex = 20;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.Restart_Click);
            // 
            // lbl_Load
            // 
            this.lbl_Load.AutoSize = true;
            this.lbl_Load.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Load.Location = new System.Drawing.Point(44, 224);
            this.lbl_Load.Name = "lbl_Load";
            this.lbl_Load.Size = new System.Drawing.Size(123, 25);
            this.lbl_Load.TabIndex = 21;
            this.lbl_Load.Text = "Load a Bullet";
            // 
            // lbl_Spin
            // 
            this.lbl_Spin.AutoSize = true;
            this.lbl_Spin.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spin.Location = new System.Drawing.Point(44, 392);
            this.lbl_Spin.Name = "lbl_Spin";
            this.lbl_Spin.Size = new System.Drawing.Size(125, 25);
            this.lbl_Spin.TabIndex = 22;
            this.lbl_Spin.Text = "Spin Chamber";
            // 
            // lbl_ShootHead
            // 
            this.lbl_ShootHead.AutoSize = true;
            this.lbl_ShootHead.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShootHead.Location = new System.Drawing.Point(241, 224);
            this.lbl_ShootHead.Name = "lbl_ShootHead";
            this.lbl_ShootHead.Size = new System.Drawing.Size(132, 25);
            this.lbl_ShootHead.TabIndex = 23;
            this.lbl_ShootHead.Text = "Shoot on Head";
            // 
            // lbl_ShootAway
            // 
            this.lbl_ShootAway.AutoSize = true;
            this.lbl_ShootAway.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShootAway.Location = new System.Drawing.Point(248, 392);
            this.lbl_ShootAway.Name = "lbl_ShootAway";
            this.lbl_ShootAway.Size = new System.Drawing.Size(112, 25);
            this.lbl_ShootAway.TabIndex = 24;
            this.lbl_ShootAway.Text = "Shoot Away";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 553);
            this.Controls.Add(this.lbl_ShootAway);
            this.Controls.Add(this.lbl_ShootHead);
            this.Controls.Add(this.lbl_Spin);
            this.Controls.Add(this.lbl_Load);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.AwayShootBTN);
            this.Controls.Add(this.SpinBTN);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Exitthegame);
            this.Controls.Add(this.Pict);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.AwayShootBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pict;
        private System.Windows.Forms.Button Exitthegame;
        private System.Windows.Forms.PictureBox Shoot;
        private System.Windows.Forms.PictureBox ReloadButton;
        private System.Windows.Forms.PictureBox SpinBTN;
        private System.Windows.Forms.PictureBox AwayShootBTN;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Label lbl_Load;
        private System.Windows.Forms.Label lbl_Spin;
        private System.Windows.Forms.Label lbl_ShootHead;
        private System.Windows.Forms.Label lbl_ShootAway;
    }
}

