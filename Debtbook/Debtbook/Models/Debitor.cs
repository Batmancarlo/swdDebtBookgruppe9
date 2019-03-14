using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;

namespace Debtbook.Models
{
    public class Debitor : BindableBase
    {
        private string name;
        private double totalDebt;
        

        public List<Debt> Debts_;
        
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }

        }


        public double TotalDebt
        {
            get { return totalDebt; }
            set { SetProperty(ref totalDebt, value); }

        }
        

        public void addDebt(string name, double size)
        {
            Debts_.Add(new Debt(name, DateTime.Now, size));
            totalDebt += size;
        }

        public Debitor(string name_, Double startdebt)
        {
            name = name_;
            Debts_ = new List<Debt>();
            if (startdebt != 0)
            {
                addDebt("Start Debt",startdebt);
            }
        }

    }
}
