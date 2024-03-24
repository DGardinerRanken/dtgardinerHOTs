using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace LoanLibrary
{
    public class ShortTermLoan : Loan
    {
        public string _name { get; set; }
        public decimal _balance { get; set; }
        public decimal _interest { get; set; }

        public ShortTermLoan(string name, string type, decimal balance, decimal interest) : base(name, type, balance)
        {
            _name = name;
            _balance = balance;
            _interest = interest;
        }

        public virtual decimal PaymentAmount
        {
            get
            {
                return 450;
            }
        }

        public void MakePayment()
        {
            balance -= 450;
            ApplyInterest();
        }

        public void ApplyInterest()
        {
            _interest = balance * .10m;
            balance += _interest;
        }


        
    }
}
