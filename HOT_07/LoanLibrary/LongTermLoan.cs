using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanLibrary
{
    public class LongTermLoan : Loan
    {
        public string _name { get; set; }
        public decimal _balance { get; set; }
        public decimal _interest { get; set; }

        public LongTermLoan(string name, string type, decimal balance) : base(name, type, balance)
        {
            _name = name;
            _balance = balance;
            _interest = 0;
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
                balance -= 200;
                ApplyInterest();
            }

        public void ApplyInterest()
            {
                _interest = balance * .05m;
                balance += _interest;
            }
       } 

    }

