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
    public partial class market : Form
    {
        public market()
        {
            InitializeComponent();
        }
        string model;
        string price;
        SQLiteConnection connect = new SQLiteConnection("Data Source=C:/Users/OHMME/Downloads/visual/Figure Shop/DBmenu.db3");
        private void pickbutton1_Click(object sender, EventArgs e)
        {
            
            model = "Nendoroid The Quintessential Quintuplets Miku Nakano";
            price = "1450";
            
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("คุณได้เลือก Nendoroid The Quintessential Quintuplets Miku Nakano ราคา 1450 บาท จำนวน 1 ชิ้น ");
            
        }

        private void pickbutton2_Click(object sender, EventArgs e)
        {
            
            model = "BINDing Creators Opinion - Kurokawa Miko ";
            price = "9900";

            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก BINDing Creators Opinion - Kurokawa Miko  ราคา 9900 บาท จำนวน 1 ชิ้น ");
        }

        private void pickbutton3_Click(object sender, EventArgs e)
        {
            
            model = "figma My Hero Academia Shoto Todoroki";
            price = "2380";
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก figma My Hero Academia Shoto Todoroki ราคา 2380 บาท จำนวน 1 ชิ้น ");
        }

        private void pickbutton4_Click(object sender, EventArgs e)
        {
            
            model = "Nendoroid More - Kigurumi Face Parts Case";
            price = "900";
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก Nendoroid More - Kigurumi Face Parts Case ราคา 900 บาท จำนวน 1 ชิ้น ");
        }

        private void pickbutton5_Click(object sender, EventArgs e)
        {
            
            model = "UTAU Kasane Teto Yoshiwara Lament ";
            price = "5350";
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก UTAU Kasane Teto Yoshiwara Lament ราคา 5350 บาท จำนวน 1 ชิ้น ");
        }

        private void pickbutton6_Click(object sender, EventArgs e)
        {
            
            model = "Nendoroid Arknights Amiya";
            price = "1700";
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก Nendoroid Arknights Amiya ราคา 1700 บาท จำนวน 1 ชิ้น ");
        }

        private void pickbutton7_Click(object sender, EventArgs e)
        {
            
            model = "Wonderful World! Kurenai Densetsu Megumin Rock";
            price = "4950";
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก Wonderful World! Kurenai Densetsu Megumin Rock ราคา 4950 บาท จำนวน 1 ชิ้น ");
        }

        private void pickbutton8_Click(object sender, EventArgs e)
        {
            
            model = "National Treasure Silver Sachet with Grape Flower";
            price = "5300";
            string query = "INSERT INTO menu(model, price) VALUES('" + model + "','" + price + "')";
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("คุณได้เลือก National Treasure Silver Sachet with Grape Flower ราคา 5300 บาท จำนวน 1 ชิ้น ");
        }

        private void รายการสงซอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void สนคาทวางขายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            market home = new market();
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
