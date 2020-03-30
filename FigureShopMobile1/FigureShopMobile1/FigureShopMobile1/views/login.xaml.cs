using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using FigureShopMobile1.Class;
using System.IO;

namespace FigureShopMobile1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void blogin_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBregister.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<user>().Where(u => u.username.Equals(inuser.Text) && u.password.Equals(inpw.Text)).FirstOrDefault();

            if (query != null)
            {
                Application.Current.MainPage = new home();
                DisplayAlert("เข้าสู่ระบบ", "เข้าสู่ระบบเรียบร้อยเเล้ว", "Yes");
            }
            else
            {
                DisplayAlert("เข้าสู่ระบบล้มเหลว", "กรุณาเข้าสู่ระบบใหม่", "Yes");
                


            }
        }

        private void bregister_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new register();
        }


    }
}