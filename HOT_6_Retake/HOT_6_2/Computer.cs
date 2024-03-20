using System;


namespace HOT_6_2
{
    public class Computer
    {
        
        //Instance Variables
        private string _name;
        private string _ipAddress;
        private string _services;


        //Full-Arg Constructor
        public Computer(string name, string ipAddress, string services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        //Getters
        public string GetName() => _name;
        
        public string GetIpAddress() => _ipAddress;
        
        public string GetServices() => _services;
        
    }
}
