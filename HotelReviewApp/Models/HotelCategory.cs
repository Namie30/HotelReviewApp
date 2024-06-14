using HotelReviewApp.Models;
using System.ComponentModel.DataAnnotations;

namespace HotelReviewApp.Models
{
    public class HotelCategory
    {
        [Key]
        public int YourPrimaryKeyPropertyName { get; set; }
        
    
    public int HotelId { get; set; }
        public int CategoryId { get; set; }
        public Hotel Hotel { get; set; }
        public Category Category { get; set; }
    }
}
