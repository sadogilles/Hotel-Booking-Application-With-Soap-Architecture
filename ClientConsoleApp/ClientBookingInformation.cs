using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    class ClientBookingInformation
    {
      
        public String ClientFirstName
        {
            get;
            set;
        }

        public String ClientLastName
        {
            get;
            set;
        }

        public String ClientCardInfo
        {
            get;
            set;
        }
        public int RoomId
        {
            get;
            set;
        }
        public String HotelName
        {
            get;
            set;
        }
        public int NumberOfStars
        {
            get;
            set;
        }
        public int NumberOfPersonToHost
        {
            get;
            set;
        }
        public int MinPrice
        {
            get;
            set;
        }
        public int MaxPrice
        {
            get;
            set;
        }
        public String ArrivalDate
        {
            get;
            set;
        }
        public String DepartureDate
        {
            get;
            set;
        }

        public String HotelTown {
            get;
            set;
        }

        public ClientBookingInformation() {
        }
    }
}
