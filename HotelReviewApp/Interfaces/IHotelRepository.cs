using HotelReviewApp.Dto;
using HotelReviewApp.DTO;
using HotelReviewApp.Models;

namespace HotelReviewApp.Interfaces
{
    public interface IHotelRepository
    {
        ICollection<Hotel> GetHotels();
        Hotel GetHotel(int id);
        Hotel GetHotel(string name);
        Hotel GetHotelTrimToUpper(HotelDto hotelCreate);
        decimal GetHotelRating(int hotelId);
        bool HotelExists(int hotelId);
        bool CreateHotel(int ownerId, int categoryId, Hotel hotel);
        bool UpdateHotel(int ownerId, int categoryId, Hotel hotel);
        bool DeleteHotel(Hotel hotel);
        bool Save();
    }
}