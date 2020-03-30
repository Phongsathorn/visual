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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void confirmRegisbutton_Click(object sender, EventArgs e)
        {
            if (fnameTextBox.Text == "" && lnameTextBox.Text == "" && IDTextBox.Text == "" && EmailTextBox.Text == "" && passregisTextBox.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                return;
            }
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/OHMME/Downloads/visual/Figure Shop/DBregister.db3;");
            string query = "INSERT INTO register(Firstname, Lastname, username, email, password) VALUES('" + fnameTextBox.Text + "','" + lnameTextBox.Text + "', '" + IDTextBox.Text + "', '" + EmailTextBox.Text + "', '" + passregisTextBox.Text + "') ";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("สมัครสมาชิกเรียบร้อย กรุณาล๊อคอินเพื่อเข้าสู่ระบบ");
            login loge = new login();
            loge.Show();
            this.Hide();
        }
    }
}
