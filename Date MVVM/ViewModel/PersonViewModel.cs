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
        private int userid;
        private Person currentPerson;
        private ICommand getPerson;
        private ICommand savePerson;
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
        public ICommand GetPerson
        {
            get
            {
                if ()
            }
        }
        public ICommand SavePerson
        {

        }

    }
}
