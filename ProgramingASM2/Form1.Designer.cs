namespace ProgramingASM2
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.Pan1 = new System.Windows.Forms.Panel();
            this.CbPassword = new System.Windows.Forms.CheckBox();
            this.LabWrong = new System.Windows.Forms.Label();
            this.BttLogin = new System.Windows.Forms.Button();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.Lab4 = new System.Windows.Forms.Label();
            this.Lab3 = new System.Windows.Forms.Label();
            this.TxbUserNameID = new System.Windows.Forms.TextBox();
            this.Lab2 = new System.Windows.Forms.Label();
            this.Lab1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pan1
            // 
            this.Pan1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pan1.BackgroundImage")));
            this.Pan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pan1.Controls.Add(this.pictureBox2);
            this.Pan1.Controls.Add(this.pictureBox1);
            this.Pan1.Controls.Add(this.CbPassword);
            this.Pan1.Controls.Add(this.LabWrong);
            this.Pan1.Controls.Add(this.BttLogin);
            this.Pan1.Controls.Add(this.TxbPassword);
            this.Pan1.Controls.Add(this.Lab4);
            this.Pan1.Controls.Add(this.Lab3);
            this.Pan1.Controls.Add(this.TxbUserNameID);
            this.Pan1.Controls.Add(this.Lab2);
            this.Pan1.Location = new System.Drawing.Point(439, 86);
            this.Pan1.Name = "Pan1";
            this.Pan1.Size = new System.Drawing.Size(629, 519);
            this.Pan1.TabIndex = 8;
            // 
            // CbPassword
            // 
            this.CbPassword.AutoSize = true;
            this.CbPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPassword.Location = new System.Drawing.Point(233, 339);
            this.CbPassword.Name = "CbPassword";
            this.CbPassword.Size = new System.Drawing.Size(163, 25);
            this.CbPassword.TabIndex = 7;
            this.CbPassword.Text = "Show Password";
            this.CbPassword.UseVisualStyleBackColor = true;
            // 
            // LabWrong
            // 
            this.LabWrong.AutoSize = true;
            this.LabWrong.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWrong.ForeColor = System.Drawing.Color.Red;
            this.LabWrong.Location = new System.Drawing.Point(175, 469);
            this.LabWrong.Name = "LabWrong";
            this.LabWrong.Size = new System.Drawing.Size(0, 24);
            this.LabWrong.TabIndex = 6;
            // 
            // BttLogin
            // 
            this.BttLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttLogin.ForeColor = System.Drawing.Color.Fuchsia;
            this.BttLogin.Image = ((System.Drawing.Image)(resources.GetObject("BttLogin.Image")));
            this.BttLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BttLogin.Location = new System.Drawing.Point(209, 386);
            this.BttLogin.Name = "BttLogin";
            this.BttLogin.Size = new System.Drawing.Size(196, 47);
            this.BttLogin.TabIndex = 5;
            this.BttLogin.Text = "Login ";
            this.BttLogin.UseVisualStyleBackColor = true;
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(123, 267);
            this.TxbPassword.Multiline = true;
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(385, 53);
            this.TxbPassword.TabIndex = 4;
            // 
            // Lab4
            // 
            this.Lab4.AutoSize = true;
            this.Lab4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab4.Image = ((System.Drawing.Image)(resources.GetObject("Lab4.Image")));
            this.Lab4.Location = new System.Drawing.Point(258, 219);
            this.Lab4.Name = "Lab4";
            this.Lab4.Size = new System.Drawing.Size(103, 23);
            this.Lab4.TabIndex = 3;
            this.Lab4.Text = "Password";
            // 
            // Lab3
            // 
            this.Lab3.AutoSize = true;
            this.Lab3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab3.Image = ((System.Drawing.Image)(resources.GetObject("Lab3.Image")));
            this.Lab3.Location = new System.Drawing.Point(244, 94);
            this.Lab3.Name = "Lab3";
            this.Lab3.Size = new System.Drawing.Size(117, 23);
            this.Lab3.TabIndex = 2;
            this.Lab3.Text = "UserName ";
            this.Lab3.Click += new System.EventHandler(this.Lab3_Click);
            // 
            // TxbUserNameID
            // 
            this.TxbUserNameID.Location = new System.Drawing.Point(123, 144);
            this.TxbUserNameID.Multiline = true;
            this.TxbUserNameID.Name = "TxbUserNameID";
            this.TxbUserNameID.Size = new System.Drawing.Size(385, 48);
            this.TxbUserNameID.TabIndex = 1;
            // 
            // Lab2
            // 
            this.Lab2.AutoSize = true;
            this.Lab2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab2.Image = ((System.Drawing.Image)(resources.GetObject("Lab2.Image")));
            this.Lab2.Location = new System.Drawing.Point(225, 18);
            this.Lab2.Name = "Lab2";
            this.Lab2.Size = new System.Drawing.Size(154, 44);
            this.Lab2.TabIndex = 0;
            this.Lab2.Text = " LOGIN ";
            // 
            // Lab1
            // 
            this.Lab1.AutoSize = true;
            this.Lab1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab1.Image = ((System.Drawing.Image)(resources.GetObject("Lab1.Image")));
            this.Lab1.Location = new System.Drawing.Point(541, -1);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(455, 70);
            this.Lab1.TabIndex = 7;
            this.Lab1.Text = "WaterBill-Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 617);
            this.Controls.Add(this.Pan1);
            this.Controls.Add(this.Lab1);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.Pan1.ResumeLayout(false);
            this.Pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pan1;
        private System.Windows.Forms.CheckBox CbPassword;
        private System.Windows.Forms.Label LabWrong;
        private System.Windows.Forms.Button BttLogin;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label Lab4;
        private System.Windows.Forms.Label Lab3;
        private System.Windows.Forms.TextBox TxbUserNameID;
        private System.Windows.Forms.Label Lab2;
        private System.Windows.Forms.Label Lab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

