using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMSample.Classes
{
    public class User : INotifyPropertyChanged
    {
        #region Private Properties
        private int userId;
        private string userName;
        private string city;
        private string state;
        private string country;
        #endregion

        #region Public Properties
        public int UserId
        {
            get
            { return userId; }
            set
            {
                userId = value;
                OnPropertyChange("UserId");
            }
        }
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChange("UserName");
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChange("City");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChange("Country");
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChange("State");
            }
        }
        #endregion

        #region INotifyProperty Changed Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
