using System;



namespace HOT_6_1
{
    public class Password
    {
        

        //Instance Variables
        private string _raw;
        private string _hash;
        

        //No Arg Constructor
        public Password()
        {

        } 

        //Full Arg Constructor
        public Password(string raw, string hash) 
        { 
            _hash = hash;
            _raw = raw;
        }

        //Getters

        public string Raw
        {
            get
            {
                return _raw;
            }
        }

        public string Hash
        {
            get
            {
                return _hash;
            }
        }
            
    }
}
