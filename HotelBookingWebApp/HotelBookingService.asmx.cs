using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HotelBookingWebApp
{
    /// <summary>
    /// Summary description for HotelBookingService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HotelBookingService : System.Web.Services.WebService
    {

       
        HotelController hotelControl = new HotelController();

       // numberofpersontohost corresponds to the number of bed
        [WebMethod]
        public List<Hotel> searchhotel(string _town, int _minPrice, int _maxPrice, int _numberofStars)
        {

            return hotelControl.hotelSearch(_town, _minPrice, _maxPrice, _numberofStars);
            
        }


        [WebMethod]
        public List<Hotel> getHotel()
        {
            return hotelControl.getHotelList();
        }


        //public string BookRoom()
        //{
        //    return "booking a room";
        //}

        [WebMethod]
        public String getBookingInformaton(int _hotel_id, int _room_id, int client_id, String _firstName, String _lastName, String _cardInfo)
        {
            return hotelControl.Booking(_hotel_id, _room_id, client_id, _firstName, _lastName, _cardInfo);
        }

        [WebMethod]
        public List<Room> getRoomFromHotel(String _hotelName) {
            return hotelControl.getRoomFromHotel(_hotelName);
        }

    }
}
