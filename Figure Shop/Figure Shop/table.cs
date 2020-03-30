using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure_Shop
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        private void picklistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void สนคาทวางขายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            market tab = new market();
            tab.Show();
            this.Hide();
        }

        private void รายการสงซอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table home = new table();
            home.Show();
            this.Hide();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
