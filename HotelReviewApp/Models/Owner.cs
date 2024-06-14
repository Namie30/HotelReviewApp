using HotelReviewApp.Models;
using System.Collections.Generic;

namespace HotelReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
       
        public Country? Country { get; set; }
        public ICollection<HotelOwner>? HotelOwners { get; set; }
    }
}