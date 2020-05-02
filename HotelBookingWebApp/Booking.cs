using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBookingWebApp
{
    public class Booking
    {
        Hotel hotel;
        List<Hotel> hotels;
        HotelModel hotelModel= new HotelModel();
        Room room;

        public int ID
        {
            get;
            set;
        }
        public DateTime Start_Date
        {
            get;
            set;
        }
        public DateTime End_Date
        {
            get;
            set;
        }
        public DateTime Booking_Date
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public Booking()
        {
            
            hotels = hotelModel.hotelList();
            room = new Room();
            hotel = new Hotel();
        }
        
        public void AddBooking(int _hotel_id, int _room_id, int client_id, String _firstName, String _lastName, String _cardInfo)
        {
        
        }
   
        public void ModifyBooking()
        {

        }
        public void DeleteBooking()
        {


        }
    }
}