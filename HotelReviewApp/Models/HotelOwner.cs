namespace HotelReviewApp.Models
{
    public class HotelOwner
    {
        public int HotelId { get; set; }
        public int OwnerId { get; set; }
        public Hotel Hotel { get; set; }
        public Owner Owner { get; set; }

    }
}
