using Shop1.Data.Models;

namespace Shop1.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
