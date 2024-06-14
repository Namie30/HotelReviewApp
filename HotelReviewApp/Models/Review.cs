using HotelReviewApp.Models;

public class Review
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; } 
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ReviewDate { get; set; }
    public Reviewer Reviewer { get; set; }
}
