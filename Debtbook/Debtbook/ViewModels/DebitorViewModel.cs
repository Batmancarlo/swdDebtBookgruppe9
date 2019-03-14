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
    public class DebitorViewModel : BindableBase
    {
        private Debitor Debitor_;
        private ObservableCollection<Debt> debts_;
        private string newDebtName, newDebtValue;
        public DebitorViewModel(Debitor debitor)
        {
            Debitor_ = debitor;
            debts_ = new ObservableCollection<Debt>(Debitor_.Debts_);
            newDebtName = "Name";
            newDebtValue = "0";
        }

        public string DebitorsName
        {
            get { return Debitor_.Name; }
        }

        public ObservableCollection<Debt> Debts
        {
            get { return debts_; }
            set { SetProperty(ref debts_, value); }
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

        ICommand _newDebtCommand;

        public ICommand AddNewDebtCommand
        {
            get
            {
                return _newDebtCommand ??(_newDebtCommand = new DelegateCommand(() =>
                {
                    if(int.TryParse(newDebtValue, out int n))
                    {
                        Debt newDebt = new Debt(newDebtName, DateTime.Now, Convert.ToInt32(newDebtValue));
                        Debitor_.addDebt(newDebtName, Convert.ToInt32(newDebtValue));
                        Debts.Add(newDebt);
                    }
                    else
                    {
                        string message = "Debt must be a number";
                        string caption = "Error in debt value";
                        MessageBox.Show(message, caption);
                    }                    

                }));
            }
        }

        
    }

}
