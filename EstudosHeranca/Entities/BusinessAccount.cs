using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosHeranca.Entities
{
    internal class BusinessAccount : Account //herança, business vai ter tudo que account tem
    {
        public double LoanLimit { get; set; }
        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount; //foi possivel ser acessada por ser protected
            }
        }
    }
}
