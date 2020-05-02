using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    class Client
    {
        public int Id
        {
            get;
            set;
        }
        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }
        public int PhoneNumber
        {
            get;
            set;
        }
        
        public Client() {

        }
        public Client (String _first_name,String _last_name)
        {

        }
    }
}
