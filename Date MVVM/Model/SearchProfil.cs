using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_MVVM.Model
{
    class SearchProfil : ObservableObjects
    {
        #region fields 
        private int sPId;
        private int minAge;
        private int maxAge;
        private string kilo;
        private int sex;
        private int userId;
        #endregion
        #region properties
        public int SPId
        {
            get { return sPId; }
            set
            {
                if (value != sPId)
                {
                    sPId = value;
                    OnPropertyChanged("SPId");
                }
            }
        }
        public int MinAge
        {
            get { return minAge; }
            set
            {
                if (value != minAge)
                {
                    minAge = value;
                    OnPropertyChanged("MinAge");
                }
            }
        }
        public int MaxAge
        {
            get { return maxAge; }
            set
            {
                if (value != maxAge)
                {
                    maxAge = value;
                    OnPropertyChanged("MaxAge");
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
