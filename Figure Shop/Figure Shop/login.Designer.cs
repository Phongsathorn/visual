namespace Figure_Shop
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Passlabel1 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.regislabel = new System.Windows.Forms.Label();
            this.registerbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.shop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Passlabel1
            // 
            this.Passlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel1.Location = new System.Drawing.Point(213, 304);
            this.Passlabel1.Name = "Passlabel1";
            this.Passlabel1.Size = new System.Drawing.Size(127, 41);
            this.Passlabel1.TabIndex = 15;
            this.Passlabel1.Text = "Password:";
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(247, 218);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(93, 41);
            this.IDLabel.TabIndex = 14;
            this.IDLabel.Text = "ชื่อผู้ใช้";
            // 
            // regislabel
            // 
            this.regislabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.regislabel.Location = new System.Drawing.Point(378, 474);
            this.regislabel.Name = "regislabel";
            this.regislabel.Size = new System.Drawing.Size(154, 23);
            this.regislabel.TabIndex = 13;
            this.regislabel.Text = "สมัครสมาชิกเพื่อเข้าสู่ระบบ";
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.Location = new System.Drawing.Point(296, 433);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(293, 38);
            this.registerbutton.TabIndex = 12;
            this.registerbutton.Text = "สมัครสมาชิก";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Lime;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(262, 369);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(372, 48);
            this.loginbutton.TabIndex = 11;
            this.loginbutton.Text = "เข้าสุ่ระบบ";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(346, 304);
            this.passwordtextBox.Multiline = true;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(257, 42);
            this.passwordtextBox.TabIndex = 10;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(346, 218);
            this.usernameTextbox.Multiline = true;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(257, 41);
            this.usernameTextbox.TabIndex = 9;
            // 
            // shop
            // 
            this.shop.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop.Location = new System.Drawing.Point(250, 53);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(384, 97);
            this.shop.TabIndex = 8;
            this.shop.Text = "Figure Shop";
            this.shop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.Passlabel1);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.regislabel);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.shop);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Passlabel1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label regislabel;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label shop;
    }
}

