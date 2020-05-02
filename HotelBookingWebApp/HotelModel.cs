using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBookingWebApp
{
    public class HotelModel
    {
        Hotel h1;
        Room r1;
        Room r2;
        Room r3;

        Hotel h2;
        Room s1;
        Room s2;
        Room s3;

        Hotel h3;
        Room t1;
        Room t2;
        Room t3;

        List<Hotel> hotels; //list of all hotels
        List<Hotel> hotelSearched;
       // Booking book;

        public HotelModel() {

            hotels = new List<Hotel>();
            hotelSearched = new List<Hotel>();
           // book = new Booking();

            h1 = new Hotel(1, "Ibis", "79 rue phillipe ", "Montpellier", "France", 0628390459, 4);  // parameters: id , name , address,town,country,telephone_number,rating
            r1 = new Room(1, 100, 4, "single"); //parameters: id, price, number of bed , capacity
            r2 = new Room(2, 50, 3, "double");
            r3 = new Room(3, 10, 3, "quad");

            h1.Rooms.Add(r1);
            h1.Rooms.Add(r2);
            h1.Rooms.Add(r3);
            h1.NumberOfRoom = h1.Rooms.Count; //set the number of rooms
            foreach (Room r in h1.Rooms) { h1.NumberOfBed += r.NumberOfBed; } //set the number of rooms
                                                                              //for each room inside the hotel get the number of beds and add to the number of bed in the hotel

            h2 = new Hotel(1, "Collisee", "79 rue Priest ", "Montpellier", "France", 0638947294, 4);
            s1 = new Room(1, 50, 2, "single");
            s2 = new Room(2, 100, 3, "double");
            s3 = new Room(3, 150, 4, "quad");

            h2.Rooms.Add(s1);
            h2.Rooms.Add(s2);
            h2.Rooms.Add(s3);
            h2.NumberOfRoom = h2.Rooms.Count; //set the number of rooms
            foreach (Room r in h2.Rooms) { h2.NumberOfBed += r.NumberOfBed; }

            h3 = new Hotel(1, "Renalviere", "79 rue Saint Lanas ", "Montpellier", "France", 0628390459, 3);
            t1 = new Room(1, 20, 1, "single");
            t2 = new Room(2, 30, 2, "double");
            t3 = new Room(3, 150, 3, "quad");


            h3.Rooms.Add(t1);
            h3.Rooms.Add(t2);
            h3.Rooms.Add(t3);
            h3.NumberOfRoom = h3.Rooms.Count; //set the number of rooms
            foreach (Room r in h3.Rooms) { h3.NumberOfBed += r.NumberOfBed; } //set the number of beds

            hotels.Add(h1);
            hotels.Add(h2);
            hotels.Add(h3);


        }
        //list of all hotels
        public List<Hotel> hotelList()
        {
            
            return hotels;

        }
    }
}