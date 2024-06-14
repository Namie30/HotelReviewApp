using HotelReviewApp.Models;
using HotelReviewApp.Interfaces;


public class CategoryRepository : ICategoryRepository
{
    private DataContext _context;
    public CategoryRepository(DataContext context)
    {
        _context = context;
    }

    public bool CategoryExists(int id)
    {
        return _context.Categories.Any(c => c.Id == id);
    }

    public ICollection<Category> GetCategories()
    {
        return _context.Categories.ToList();
    }

    public Category GetCategory(int id)
    {
        return _context.Categories.FirstOrDefault(e => e.Id == id) ?? new Category();
    }

    public ICollection<Hotel> GetHotelByCategory(int categoryId)
    {
        return _context.HotelCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Hotel).ToList();
    }

    public bool CreateCategory(Category category)
    {
        _context.Categories.Add(category);
        return Save();
    }

    public bool UpdateCategory(Category category)
    {
        _context.Categories.Update(category);
        return Save();
    }

    public bool DeleteCategory(Category category)
    {
        _context.Categories.Remove(category);
        return Save();
    }

    public bool Save()
    {
        return (_context.SaveChanges() >= 0);
    }
   
}

