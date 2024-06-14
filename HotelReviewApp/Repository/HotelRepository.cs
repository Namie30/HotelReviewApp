
using HotelReviewApp.Dto;
using HotelReviewApp.DTO;
using HotelReviewApp.Interfaces;
using HotelReviewApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelReviewApp.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly DataContext _context;

        public HotelRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateHotel(int ownerId, int categoryId, Hotel hotel)
        {
            var hotelOwnerEntity = _context.Owners.FirstOrDefault(a => a.Id == ownerId);
            var category = _context.Categories.FirstOrDefault(a => a.Id == categoryId);

            var hotelOwner = new HotelOwner()
            {
                Owner = hotelOwnerEntity,
                Hotel = hotel,
            };

            _context.Add(hotelOwner);

            var hotelCategory = new HotelCategory()
            {
                Category = category,
                Hotel = hotel,
            };

            _context.Add(hotelCategory);

            _context.Add(hotel);

            return Save();
        }

        public bool DeleteHotel(Hotel hotel)
        {
            _context.Remove(hotel);
            return Save();
        }

        public Hotel GetHotel(int id)
        {
            return _context.Hotels.FirstOrDefault(p => p.Id == id);
        }

        public Hotel GetHotel(string name)
        {
            return _context.Hotels.FirstOrDefault(p => p.Name == name);
        }

        public decimal GetHotelRating(int hotelId)
        {
            var reviews = _context.Reviews.Where(r => r.Hotel.Id == hotelId);

            if (reviews.Count() <= 0)
                return 0;

            return ((decimal)reviews.Sum(r => r.Rating) / reviews.Count());
        }

        public ICollection<Hotel> GetHotels()
        {
            return _context.Hotels.OrderBy(p => p.Id).ToList();
        }

        public Hotel GetHotelTrimToUpper(HotelDto hotelDto)
        {
            return GetHotels().FirstOrDefault(c => c.Name.Trim().ToUpper() == hotelDto.Name.Trim().ToUpper());
        }

        public bool HotelExists(int hotelId)
        {
            return _context.Hotels.Any(p => p.Id == hotelId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool UpdateHotel(int ownerId, int categoryId, Hotel hotel)
        {
            _context.Update(hotel);
            return Save();
        }
    }
}
