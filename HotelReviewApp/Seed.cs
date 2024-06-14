
using HotelReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.HotelOwners.Any())
            {
                var hotelOwners = new List<HotelOwner>()
                {
                    new HotelOwner()
                    {
                       Hotel = new Hotel()
                            {
                                Name = "Hotel California",
                                BuildDate = new DateTime(1976, 12, 8),
                                Address = "Beverly Hills, California",
                                Rating = 5,
                                NumberOfRooms = 200,
                                Reviews = new List<Review>()
                                {
                                    new Review { ReviewDate = new DateTime(2022, 1, 1), Comment = "Wonderful place to stay!", Reviewer = new Reviewer() { Name = "Alice Johnson", Email = "alice@example.com" }},
                                    new Review { ReviewDate = new DateTime(2022, 1, 2), Comment = "Had a great time!", Reviewer = new Reviewer() { Name = "Bob Smith", Email = "bob@example.com" }}
                                }
                            },
                        Owner = new Owner()
                        {
                            FirstName = "John",
                            LastName = "Doe",
                          
                            Country = new Country()
                            {
                                Name = "USA"
                            }
                        }
                    },
                    new HotelOwner()
                    {
                        Hotel = new Hotel()
                            {
                                Name = "The Grand Budapest",
                                BuildDate = new DateTime(1932, 4, 1),
                                Address = "Budapest, Hungary",
                                Rating = 5,
                                NumberOfRooms = 350,
                                Reviews = new List<Review>()
                                {
                                    new Review { ReviewDate = new DateTime(2022, 1, 3), Comment = "Amazing experience!", Reviewer = new Reviewer() { Name = "Charlie Brown", Email = "charlie@example.com" }},
                                    new Review { ReviewDate = new DateTime(2022, 1, 4), Comment = "Would love to visit again.", Reviewer = new Reviewer() { Name = "David Clark", Email = "david@example.com" }}
                                }
                            },
                        Owner = new Owner()
                        {
                            FirstName = "Emily",
                            LastName = "White",
                           
                            Country = new Country()
                            {
                                Name = "Hungary"
                            }
                        }
                    },
                    new HotelOwner()
                    {
                        Hotel = new Hotel()
                            {
                                Name = "The Ritz London",
                                BuildDate = new DateTime(1906, 5, 24),
                                Address = "150 Piccadilly, London",
                                Rating = 5,
                                NumberOfRooms = 130,
                                Reviews = new List<Review>()
                                {
                                    new Review { ReviewDate = new DateTime(2022, 1, 5), Comment = "Luxurious and comfortable!", Reviewer = new Reviewer() { Name = "Eve Adams", Email = "eve@example.com" }},
                                    new Review { ReviewDate = new DateTime(2022, 1, 6), Comment = "Exceptional service!", Reviewer = new Reviewer() { Name = "Franklin Davis", Email = "franklin@example.com" }}
                                }
                            },
                        Owner = new Owner()
                        {
                            FirstName = "George",
                            LastName = "Martin",
                            
                            Country = new Country()
                            {
                                Name = "UK"
                            }
                        }
                    }
                };

                dataContext.HotelOwners.AddRange(hotelOwners);
                dataContext.SaveChanges();
            }
        }
    }
}