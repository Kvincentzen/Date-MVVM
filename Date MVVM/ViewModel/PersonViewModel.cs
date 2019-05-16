using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Date_MVVM.Model;

namespace Date_MVVM.ViewModel
{
    class PersonViewModel : ObservableObjects
    {
        private int userid;
        private Person currentPerson;
        ICommand GetPerson;
        ICommand SavePerson;
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

    }
}
