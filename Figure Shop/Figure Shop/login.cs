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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string user = usernameTextbox.Text.Trim();
            string password = passwordtextBox.Text.Trim();
            market home = new market();

            if (user == "" && password == "")
            {
                MessageBox.Show("กรุณากรอกIDและPasswordเพื่อเข้าใช้งาน");
            }
            else
            {
                if (user == "admin" && password == "123456")
                {
                    MessageBox.Show("เข้าสู่ระบบเรียบร้อย");
                    foradmin admin = new foradmin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/OHMME/Downloads/visual/Figure Shop/DBregister.db3;");
                    string query = "SELECT * from register Where username = '" + user + "' and password = '" + password + "'";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    DataTable dtable = new DataTable();
                    SQLiteDataAdapter sata = new SQLiteDataAdapter(cmd);

                    sata.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("เข้าสู่ระบบเรียบร้อย");
                        market homepage = new market();
                        this.Hide();
                        homepage.Show();
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านผิด กรุณากรอกใหม่อีกครั้ง");
                    }
                }
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            register regis = new register();
            regis.Show();
            this.Hide();
        }
    }
}
