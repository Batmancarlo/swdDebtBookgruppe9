using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Debtbook.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace Debtbook.ViewModels
{
    public class AddDebitorViewModel : BindableBase
    {
        private ObservableCollection<Debitor> debitors_;
        
        private string newDebtName, newDebtValue;
        public AddDebitorViewModel(ObservableCollection<Debitor> debitors)
        {
            debitors_ = debitors;
            newDebtName = "Name";
            newDebtValue = "0";
        }

        public String NewDebtName
        {
            get { return newDebtName; }
            set
            {
                SetProperty(ref newDebtName, value);
            }
        }

        public String NewDebtValue
        {
            get { return newDebtValue; }
            set
            {
                SetProperty(ref newDebtValue, value);
            }
        }

        ICommand _AddNewDebitor;

        public ICommand AddNewDebitor
        {
            get
            {
                return _AddNewDebitor ?? (_AddNewDebitor = new DelegateCommand(() =>
                {
                    if (int.TryParse(newDebtValue, out int n))
                        debitors_.Add(new Debitor(newDebtName,Convert.ToDouble(newDebtValue)));
                    else
                    {
                        string message = "Starting debt must be a number";
                        string caption = "Error in debt value";
                        MessageBox.Show(message,caption);
                    }
                 }));
            }
        }

    }
}
