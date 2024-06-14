namespace HotelReviewApp.Models
{
    public class Reviewer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
