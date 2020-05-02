using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    public class Room
    {
        public int Id
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }
        //number of bed in  the room
        public int NumberOfBed
        {
            get;
            set;
        }
        //capacity of bed: {single,double,quad}
        public string Capacity
        {
            get;
            set;
        }
        //state determines whether the room is occupy or not
        public Boolean State
        {
            get;
            set;
        }

        public Room()
        {
            State = false;
        }

        public Room(int _id, int _price, int _numberOfBed, String _capacity)
        {
            Id = _id;
            Price = _price;
            NumberOfBed = _numberOfBed;
            Capacity = _capacity;
            State = false;
        }

    }
}
