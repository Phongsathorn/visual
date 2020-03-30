namespace Figure_Shop
{
    partial class table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(table));
            this.label1 = new System.Windows.Forms.Label();
            this.Passlabel1 = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.editbutton = new System.Windows.Forms.Button();
            this.comfirmbutton = new System.Windows.Forms.Button();
            this.shoplabel = new System.Windows.Forms.Label();
            this.picklistbox = new System.Windows.Forms.ListBox();
            this.mainmanu = new System.Windows.Forms.MenuStrip();
            this.สนคาทวางขายToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายการสงซอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmanu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 51;
            this.label1.Text = "ราคาทั้งหมด";
            // 
            // Passlabel1
            // 
            this.Passlabel1.BackColor = System.Drawing.Color.Lime;
            this.Passlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel1.Location = new System.Drawing.Point(625, 61);
            this.Passlabel1.Name = "Passlabel1";
            this.Passlabel1.Size = new System.Drawing.Size(152, 41);
            this.Passlabel1.TabIndex = 50;
            this.Passlabel1.Text = "จำนวนสั่งซื้อ";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextBox.Location = new System.Drawing.Point(650, 193);
            this.pricetextBox.Multiline = true;
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(185, 35);
            this.pricetextBox.TabIndex = 49;
            this.pricetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextbox
            // 
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.Location = new System.Drawing.Point(650, 108);
            this.totalTextbox.Multiline = true;
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Size = new System.Drawing.Size(185, 35);
            this.totalTextbox.TabIndex = 48;
            this.totalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.editbutton.Location = new System.Drawing.Point(714, 493);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(156, 48);
            this.editbutton.TabIndex = 47;
            this.editbutton.Text = "แก้ไข";
            this.editbutton.UseVisualStyleBackColor = false;
            // 
            // comfirmbutton
            // 
            this.comfirmbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.comfirmbutton.Location = new System.Drawing.Point(536, 493);
            this.comfirmbutton.Name = "comfirmbutton";
            this.comfirmbutton.Size = new System.Drawing.Size(156, 48);
            this.comfirmbutton.TabIndex = 46;
            this.comfirmbutton.Text = "ยืนยัน";
            this.comfirmbutton.UseVisualStyleBackColor = false;
            // 
            // shoplabel
            // 
            this.shoplabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.shoplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoplabel.Location = new System.Drawing.Point(146, 9);
            this.shoplabel.Name = "shoplabel";
            this.shoplabel.Size = new System.Drawing.Size(217, 44);
            this.shoplabel.TabIndex = 45;
            this.shoplabel.Text = "รายการสั่งซื้อ";
            // 
            // picklistbox
            // 
            this.picklistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklistbox.FormattingEnabled = true;
            this.picklistbox.ItemHeight = 31;
            this.picklistbox.Location = new System.Drawing.Point(142, 61);
            this.picklistbox.Name = "picklistbox";
            this.picklistbox.Size = new System.Drawing.Size(477, 407);
            this.picklistbox.TabIndex = 44;
            this.picklistbox.SelectedIndexChanged += new System.EventHandler(this.picklistbox_SelectedIndexChanged);
            // 
            // mainmanu
            // 
            this.mainmanu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainmanu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainmanu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainmanu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.สนคาทวางขายToolStripMenuItem,
            this.รายการสงซอToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            this.mainmanu.Location = new System.Drawing.Point(0, 0);
            this.mainmanu.Name = "mainmanu";
            this.mainmanu.Size = new System.Drawing.Size(156, 553);
            this.mainmanu.TabIndex = 43;
            this.mainmanu.Text = "menuStrip1";
            // 
            // สนคาทวางขายToolStripMenuItem
            // 
            this.สนคาทวางขายToolStripMenuItem.Name = "สนคาทวางขายToolStripMenuItem";
            this.สนคาทวางขายToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.สนคาทวางขายToolStripMenuItem.Text = "สินค้าที่วางขาย";
            this.สนคาทวางขายToolStripMenuItem.Click += new System.EventHandler(this.สนคาทวางขายToolStripMenuItem_Click);
            // 
            // รายการสงซอToolStripMenuItem
            // 
            this.รายการสงซอToolStripMenuItem.Name = "รายการสงซอToolStripMenuItem";
            this.รายการสงซอToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.รายการสงซอToolStripMenuItem.Text = "รายการสั่งซื้อ";
            this.รายการสงซอToolStripMenuItem.Click += new System.EventHandler(this.รายการสงซอToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passlabel1);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.comfirmbutton);
            this.Controls.Add(this.shoplabel);
            this.Controls.Add(this.picklistbox);
            this.Controls.Add(this.mainmanu);
            this.Name = "table";
            this.Text = "table";
            this.mainmanu.ResumeLayout(false);
            this.mainmanu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Passlabel1;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox totalTextbox;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button comfirmbutton;
        private System.Windows.Forms.Label shoplabel;
        private System.Windows.Forms.ListBox picklistbox;
        private System.Windows.Forms.MenuStrip mainmanu;
        private System.Windows.Forms.ToolStripMenuItem สนคาทวางขายToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายการสงซอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
    }
}