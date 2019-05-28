using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Date_MVVM.Model;

namespace Date_MVVM.Model
{
    public class Person : ObservableObjects
    {
        #region fields 
        private string fName;
        private string lName;
        private int age;
        private string height;
        private string kilo;
        private int sex;
        private int userId;
        #endregion
        #region properties
        public string FName
        {
            get { return fName; }
            set
            {
                if (value != fName)
                {
                    fName = value;
                    OnPropertyChanged("FName");
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value != lName)
                {
                    lName = value;
                    OnPropertyChanged("LName");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value != age)
                {
                    age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
        public string Height
        {
            get { return height; }
            set
            {
                if (value != height)
                {
                    height = value;
                    OnPropertyChanged("Height");
                }
            }
        }
        public string Kilo
        {
            get { return kilo; }
            set
            {
                if (value != kilo)
                {
                    kilo = value;
                    OnPropertyChanged("Kilo");
                }
            }
        }
        public int Sex
        {
            get { return sex; }
            set
            {
                if (value != sex)
                {
                    sex = value;
                    OnPropertyChanged("Sex");
                }
            }
        }
        public int UserId
        {
            get { return userId; }
            set
            {
                if (value != userId)
                {
                    userId = value;
                    OnPropertyChanged("UserID");
                }
            }
        }
        #endregion
    }
}
