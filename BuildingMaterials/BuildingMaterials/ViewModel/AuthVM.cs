using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BuildingMaterials.DbStorage;
using BuildingMaterials.View;

namespace BuildingMaterials.ViewModel
{
    public class AuthVM : BaseViewModel
    {
        private User _user;

        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private bool Authorizaton(string login, string password)
        {
            using (var db = new TradeEntities())
            {
                var res = db.User.FirstOrDefault(user => user.UserLogin == login && user.UserPassword == password);
                _user = res;
                if (res != null)
                    return true;
                return false;
            }
        }

        public void AuthInApp()
        {
            bool res = Authorizaton(Login, Password);
            if (res)
            {
                var AppMV = new GoodsWindow(null);
                AppMV.Show();
                foreach (Window w in Application.Current.Windows)
                    if (w is MainWindow) w.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль\n" +
                    "Или такого пользователя не сущесвует","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
