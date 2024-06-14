﻿namespace HotelReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<HotelCategory> HotelCategories { get; set; }
    }
}
