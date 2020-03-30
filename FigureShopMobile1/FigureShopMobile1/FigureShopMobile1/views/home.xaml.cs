using FigureShopMobile1.Class;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FigureShopMobile1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class home : ContentPage
    {
        
        public home()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBshop.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<shop>();
            var modelshop = new shop()
            {
                model = amiya.Text,
                price = pr_amiya.Text,
                
            };
            db.Insert(modelshop);
            DisplayAlert("เเจ้งเตือน", "คุณได้เลือก Nendoroid Arknights Amiya ราคา 1700 บาท จำนวน 1 ชิ้น ", "ตกลง");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBshop.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<shop>();
            var modelshop = new shop()
            {
                model = kasane.Text,
                price = pr_kasane.Text,

            };
            db.Insert(modelshop);
            DisplayAlert("เเจ้งเตือน", "คุณได้เลือก UTAU Kasane Teto Yoshiwara Lament ราคา 5350 บาท จำนวน 1 ชิ้น ", "ตกลง");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBshop.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<shop>();
            var modelshop = new shop()
            {
                model = megumin.Text,
                price = pr_megumin.Text,

            };
            db.Insert(modelshop);
            DisplayAlert("เเจ้งเตือน", "คุณได้เลือก Wonderful World! Kurenai Densetsu Megumin Rock ราคา 4950 บาท จำนวน 1 ชิ้น ", "ตกลง");
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBshop.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<shop>();
            var modelshop = new shop()
            {
                model = miko.Text,
                price = pr_miko.Text,

            };
            db.Insert(modelshop);
            DisplayAlert("เเจ้งเตือน","คุณได้เลือก BINDing Creators Opinion - Kurokawa Miko  ราคา 9900 บาท จำนวน 1 ชิ้น ", "ตกลง");
        }

        private Task DisplayAlert(string v, string v1)
        {
            throw new NotImplementedException();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Application.Current.MainPage = new login();
        }
    }
}