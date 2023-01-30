using Shop1.Data.interfaces;
using Shop1.Data.Models;

namespace Shop1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>  {
                new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутрегннего сгорания"}

                };
            } 
        }
    }
}
