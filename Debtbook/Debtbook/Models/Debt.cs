using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtbook.Models
{
    public class Debt
    {
        public DateTime DateOfDebt_ { get; set; }

        public double SizeOfDebt_ { get; set; }

        public string DebtName_ { get; set; }

        public Debt(string debtname, DateTime DD, double SD)
        {
            DateOfDebt_ = DD;
            SizeOfDebt_ = SD;
            DebtName_ = debtname;
        }
    }
}
