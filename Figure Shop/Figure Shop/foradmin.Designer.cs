namespace Figure_Shop
{
    partial class foradmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foradmin));
            this.shop = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.mainmanu2 = new System.Windows.Forms.MenuStrip();
            this.รายชื่อสมาชิกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายการสงซอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.mainmanu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop
            // 
            this.shop.BackColor = System.Drawing.Color.Chartreuse;
            this.shop.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop.Location = new System.Drawing.Point(231, 9);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(565, 97);
            this.shop.TabIndex = 40;
            this.shop.Text = "Figure Shop(for admin)";
            this.shop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(163, 118);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(701, 386);
            this.dataGridView.TabIndex = 39;
            // 
            // mainmanu2
            // 
            this.mainmanu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainmanu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainmanu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainmanu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายชื่อสมาชิกToolStripMenuItem,
            this.รายการสงซอToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            this.mainmanu2.Location = new System.Drawing.Point(0, 0);
            this.mainmanu2.Name = "mainmanu2";
            this.mainmanu2.Size = new System.Drawing.Size(156, 553);
            this.mainmanu2.TabIndex = 38;
            this.mainmanu2.Text = "menuStrip1";
            // 
            // รายชื่อสมาชิกToolStripMenuItem
            // 
            this.รายชื่อสมาชิกToolStripMenuItem.Name = "รายชื่อสมาชิกToolStripMenuItem";
            this.รายชื่อสมาชิกToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.รายชื่อสมาชิกToolStripMenuItem.Text = "รายชื่อสมาชิก";
            this.รายชื่อสมาชิกToolStripMenuItem.Click += new System.EventHandler(this.รายชื่อสมาชิกToolStripMenuItem_Click_1);
            // 
            // รายการสงซอToolStripMenuItem
            // 
            this.รายการสงซอToolStripMenuItem.Name = "รายการสงซอToolStripMenuItem";
            this.รายการสงซอToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.รายการสงซอToolStripMenuItem.Text = "รายการสั่งซื้อ";
            this.รายการสงซอToolStripMenuItem.Click += new System.EventHandler(this.รายการสงซอToolStripMenuItem_Click_1);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click_1);
            // 
            // foradmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mainmanu2);
            this.Name = "foradmin";
            this.Text = "foradmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.mainmanu2.ResumeLayout(false);
            this.mainmanu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shop;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip mainmanu2;
        private System.Windows.Forms.ToolStripMenuItem รายชื่อสมาชิกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายการสงซอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
    }
}