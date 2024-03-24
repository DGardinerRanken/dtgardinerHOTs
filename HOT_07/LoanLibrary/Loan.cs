using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanLibrary
{
    public abstract class Loan
    {
        private string _name { get; set; }
        private string _type { get; set; }
        private decimal _balance { get; set; }
        
        //Full Arg Constructor
        public Loan(string name, string type, decimal balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }

        //Getters

        public string name
        {
            get
            {
                return _name;
            }
        }

        public string type
        {
            get
            {
                return _type;
            }
        }

        public decimal balance 
        {
            get
            {
                return _balance;
            }
            set { }
          
        }

    }
}
