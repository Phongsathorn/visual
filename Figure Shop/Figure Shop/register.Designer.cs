namespace Figure_Shop
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.confirmRegisbutton = new System.Windows.Forms.Button();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.passregisTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.RegisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmRegisbutton
            // 
            this.confirmRegisbutton.BackColor = System.Drawing.Color.Lime;
            this.confirmRegisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmRegisbutton.Location = new System.Drawing.Point(306, 461);
            this.confirmRegisbutton.Name = "confirmRegisbutton";
            this.confirmRegisbutton.Size = new System.Drawing.Size(317, 56);
            this.confirmRegisbutton.TabIndex = 13;
            this.confirmRegisbutton.Text = "บันทึกและสมัครสมาชิก";
            this.confirmRegisbutton.UseVisualStyleBackColor = false;
            this.confirmRegisbutton.Click += new System.EventHandler(this.confirmRegisbutton_Click);
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.Location = new System.Drawing.Point(454, 131);
            this.lnameTextBox.Multiline = true;
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(215, 50);
            this.lnameTextBox.TabIndex = 12;
            this.lnameTextBox.Text = "นามสกุล";
            // 
            // passregisTextBox
            // 
            this.passregisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passregisTextBox.Location = new System.Drawing.Point(213, 378);
            this.passregisTextBox.Multiline = true;
            this.passregisTextBox.Name = "passregisTextBox";
            this.passregisTextBox.Size = new System.Drawing.Size(456, 50);
            this.passregisTextBox.TabIndex = 11;
            this.passregisTextBox.Text = "รหัสผ่าน";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(213, 298);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(456, 50);
            this.EmailTextBox.TabIndex = 10;
            this.EmailTextBox.Text = "example@gmail.com";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(213, 212);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(456, 50);
            this.IDTextBox.TabIndex = 9;
            this.IDTextBox.Text = "ID";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.Location = new System.Drawing.Point(213, 131);
            this.fnameTextBox.Multiline = true;
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(215, 50);
            this.fnameTextBox.TabIndex = 8;
            this.fnameTextBox.Text = "ชื่อ";
            // 
            // RegisLabel
            // 
            this.RegisLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegisLabel.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisLabel.Location = new System.Drawing.Point(332, 36);
            this.RegisLabel.Name = "RegisLabel";
            this.RegisLabel.Size = new System.Drawing.Size(260, 68);
            this.RegisLabel.TabIndex = 7;
            this.RegisLabel.Text = "สมัครสมาชิก";
            this.RegisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.confirmRegisbutton);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.passregisTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.RegisLabel);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmRegisbutton;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox passregisTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.Label RegisLabel;
    }
}