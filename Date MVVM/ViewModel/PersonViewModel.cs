using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Date_MVVM.Model;

namespace Date_MVVM.ViewModel
{
    public class PersonViewModel : ObservableObjects
    {
        #region fields
        private int userId;
        private Person currentPerson;
        private ICommand getPersonCommand;
        private ICommand savePersonCommand;
        #endregion
        #region properties
        public Person CurrentPerson
        {
            get { return currentPerson; }
            set
            {
                if (value != currentPerson)
                {
                    currentPerson = value;
                    OnPropertyChanged("CurrentPerson)");
                }
            }
        }
        public ICommand SavePersonCommand
        {
            get
            {
                if (savePersonCommand == null)
                {
                    savePersonCommand = new RelayCommand(
                        param => SavePerson(),
                        param => (currentPerson != null)
                        );
                }
                return savePersonCommand;
            }
        }
        public ICommand GetPersonCommand
        {
            get
            {
                if (getPersonCommand == null)
                {
                    getPersonCommand = new RelayCommand(
                        param => UserInfo(),
                        param => (currentPerson != null)
                        );
                }
                return getPersonCommand;
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
                    OnPropertyChanged("UserId");
                }
            }
        }
        #endregion
        #region methods
        private void UserInfo()
        {
            Person p = new Person();
            p.UserId = UserId;
            p.FName = "Mike";
            p.LName = "Svendsen";
            p.Age = 30;
            p.Height = "200";
            p.Kilo = "80";
            p.Sex = 1;
            CurrentPerson = p;
        }
        private void SavePerson()
        { }
        #endregion
    }
}
