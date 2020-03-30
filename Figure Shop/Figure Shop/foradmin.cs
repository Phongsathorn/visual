using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Figure_Shop
{
    public partial class foradmin : Form
    {
        public foradmin()
        {
            InitializeComponent();
        }

        private void รายการสงซอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=D:/รวมงาน/visual/Figure Shop/DBmenu.db3;");
            conn.Open();
            string query = "SELECT * from menu";
            SQLiteCommand cmdd = new SQLiteCommand(query, conn);

            DataTable dtb = new DataTable();
            SQLiteDataAdapter dap = new SQLiteDataAdapter(cmdd);
            dap.Fill(dtb);

            dataGridView.DataSource = dtb;
        }

        private void รายชื่อสมาชิกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=D:/รวมงาน/visual/Figure Shop/DBregister.db3;");
            con.Open();
            string query = "SELECT * from register";
            SQLiteCommand cmdd = new SQLiteCommand(query, con);

            DataTable dtb = new DataTable();
            SQLiteDataAdapter dap = new SQLiteDataAdapter(cmdd);
            dap.Fill(dtb);

            dataGridView.DataSource = dtb;
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void รายชื่อสมาชิกToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/OHMME/Downloads/visual/Figure Shop/DBregister.db3;");
            con.Open();
            string query = "SELECT * from register";
            SQLiteCommand cmdd = new SQLiteCommand(query, con);

            DataTable dtb = new DataTable();
            SQLiteDataAdapter dap = new SQLiteDataAdapter(cmdd);
            dap.Fill(dtb);

            dataGridView.DataSource = dtb;
        }

        private void รายการสงซอToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/OHMME/Downloads/visual/Figure Shop/DBmenu.db3;");
            conn.Open();
            string query = "SELECT * from menu";
            SQLiteCommand cmdd = new SQLiteCommand(query, conn);

            DataTable dtb = new DataTable();
            SQLiteDataAdapter dap = new SQLiteDataAdapter(cmdd);
            dap.Fill(dtb);

            dataGridView.DataSource = dtb;
        }

        private void ออกจากระบบToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
