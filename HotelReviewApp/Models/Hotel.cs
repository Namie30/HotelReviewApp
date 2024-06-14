namespace HotelReviewApp.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BuildDate { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
        public int NumberOfRooms { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<HotelOwner> HotelOwners { get; set; }
    }
}
