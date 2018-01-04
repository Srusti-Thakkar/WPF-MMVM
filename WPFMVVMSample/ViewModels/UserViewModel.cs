using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMSample.Classes;

namespace WPFMVVMSample.ViewModels
{
    class UserViewModel
    {
        private IList<User> _UsersList;

        public UserViewModel()
        {
            _UsersList = new List<User>
            {
                new User{UserId = 1,UserName="Srusti Thakkar" ,City="Anand",State="GUJ",Country="INDIA"},

            };
        }

        public IList<User> Users
        {
            get
            {
                return _UsersList;
            }
            set
            {
                _UsersList = value;
            }
        }

        private ICommand Ucommand;

        public ICommand UpdateCommand
        {
            get
            {
                if (Ucommand == null)
                    Ucommand = new Updater();
                return Ucommand;
            }
            set
            {
                Ucommand = value;
            }
        }
        private class Updater : ICommand
        {
            #region ICommand Members

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
