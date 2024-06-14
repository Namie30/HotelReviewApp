using HotelReviewApp.Models;


namespace HotelReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Hotel> GetHotelByCategory(int categoryId);

        ICollection<Category> GetCategories();
        Category GetCategory(int id);
     
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}
