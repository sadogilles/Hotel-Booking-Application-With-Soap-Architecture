using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    public class Hotel
    {
        public int ID
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public String Town
        {
            get;
            set;
        }
        public String Country
        {
            get;
            set;
        }

        public int PhoneNumber
        {
            get;
            set;
        }
        public int Rating
        {
            get;
            set;
        }


        public int NumberOfRoom
        {
            get;
            set;
        } = 0;

        public int NumberOfBed
        {
            get;
            set;
        }

        public List<Room> Rooms
        {
            get;
            set;
        } = new List<Room>(); //initilisation


        public Hotel()
        {

        }
        //simple hotel
        public Hotel(int _id, String _name, int _rating, int _room)
        {
            ID = _id;
            Name = _name;
            Rating = _rating;
            NumberOfRoom = _room;


        }
        //More complete hotel
        public Hotel(int _id, String _name, String _address, String _town, String _country, int _telephone_number, int _rating)
        {
            ID = _id;
            Name = _name;
            Address = _address;
            Town = _town;
            Country = _country;
            Rating = _rating;
            PhoneNumber = _telephone_number;
            Rooms = new List<Room>();

        }
    }
}
