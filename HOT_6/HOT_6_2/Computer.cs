using System;


namespace HOT_6_2
{
    public class Computer
    {
        //Again I just went for the points I know I can get, I apoligize I cannot seem to figure out
        //How to work the class file into all of this

        //Instance Variables
        private string _name;
        private string _ipAddress;
        private string _services;



        public Computer(string name, string ipAddress, string services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetIpAddress()
        {
            return _ipAddress;
        }
        public string GetServices()
        {
            return _services;
        }
    }
}
