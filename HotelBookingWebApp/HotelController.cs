using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBookingWebApp
{
    public class HotelController
    {
        List<Hotel> hotelSearched;
        List<Hotel> hotels;
        HotelModel hotelModel;
        Hotel hotel;
        Room room;
        List<Room> rooms;
        // 8\Booking booking;

        public HotelController()
        {
            hotelModel = new HotelModel();
            hotelSearched = new List<Hotel>();
            hotels = hotelModel.hotelList();
            hotel = new Hotel();
            room = new Room();
            rooms = new List<Room>();
           // booking = new Booking();
        }
        //simple search
       public List<Hotel> hotelSearch(String  _town, int _minPrice, int _maxPrice,int _numberOfStars)
        {



            foreach (Hotel hotel in hotels)
            {
                if (hotel.Town.Equals(_town) && hotel.Rating.Equals(_numberOfStars))
                {

                    foreach (Room room in hotel.Rooms)
                    {
                        if (room.Price > _minPrice && room.Price < _maxPrice)
                        {
                            //room within price exist
                            hotelSearched.Add(hotel);
                            break; //go to to next hotel

                        }
                        else {
                             //do nothing 
                        }

                       
                    }

                }
                
            }


            return hotelSearched; //no hotel found 
        }

        public List<Hotel> getHotelList()
        {
            return hotelModel.hotelList();
        }
        //public String Booking(String _firstName,String _lastName,String _cardInfo) {
        //    return book.AddBooking(_firstName, _lastName, _cardInfo);
        //}

        public String Booking(int _hotel_id, int _room_id, int _client_id, String _firstName, String _lastName, String _cardInfo)
        {
            //return booking.AddBooking(_hotel_id, _room_id, _client_id, _firstName, _lastName, _cardInfo);


            //find the hotel
            foreach (Hotel h in hotels)
            {
                if (_hotel_id.Equals(h.ID))
                {
                    hotel = h;
                    //find the room
                    foreach (Room r in h.Rooms)
                    {
                        if (r.Id.Equals(_room_id))
                        {
                            room = r;
                        }

                    }

                }

                //change state of room
                room.State = true;
                //reduce the number of rooms
                room.NumberOfBed = room.NumberOfBed--;
                return "Success";
            }
            return "Error";
        }

        public List<Room> getRoomFromHotel(String _hotelName)
        {
            foreach (Hotel h in hotels)
            {

                //search hotel
                if (h.Name.Equals(_hotelName))
                {
                    hotel = h;

                    foreach (Room r in hotel.Rooms) {
                        rooms.Add(r);
                    }
                }

                

            }

            return rooms;
        }
    }
}