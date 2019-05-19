using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Date_MVVM.Model;

namespace Date_MVVM.ViewModel
{
    class PersonViewModel : ObservableObjects
    {
        private int userId;
        private Person currentPerson;
        private ICommand getPersonCommand;
        private ICommand savePersonCommand;
        public Person CurrentPerson
        {
            get { return currentPerson; }
            set
            {
                if (value != currentPerson)
                {
                    currentPerson = value;
                    OnPropertyChanged("currentPerson)");
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
                        param => GetPerson(),
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
        private void GetPerson()
        {
            // You should get the product from the database
            // but for now we'll just return a new object
        }

        private void SavePerson()
        {
            // You would implement your Product save here
        }
    }

}
}
