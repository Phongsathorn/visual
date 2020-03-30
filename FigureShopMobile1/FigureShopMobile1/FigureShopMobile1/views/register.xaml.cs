using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using FigureShopMobile1.Class;


namespace FigureShopMobile1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class register : ContentPage
    {
        public register()
        {
            InitializeComponent();
        }

        private void b_regis_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBregister.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<user>();
            var userregis = new user()
            {
                firstname = infname.Text,
                lastname = inlname.Text,
                username = inuname.Text,
                email = inemail.Text,
                password = inpass.Text
            };
            db.Insert(userregis);
            DisplayAlert("เเจ้งเตือน", "สมัครสมาชิกเรียบร้อย กรุณาเข้าสู่ระบบเพื่อเข้าใช้งาน", "ตกลง");
            Application.Current.MainPage = new login();
        }
        private Task DisplayAlert(string v, string v1)
        {
            throw new NotImplementedException();
        }
    }
}