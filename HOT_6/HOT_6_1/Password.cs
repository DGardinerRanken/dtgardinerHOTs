using System;
using System.Security.Cryptography.X509Certificates;


namespace HOT_6_1
{
    public class Password
    {
        //I tried for a couple hours to get this to work with the Class, but I'm still feeling
        //pretty lost in this chapter so i just gave up and am going for the other points on this HOT,
        //I apologize

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

        public string GetRaw()
        {
            return _raw;
        }

        public string GetHash()
        {
            return _hash;
        }

        
    }
}
