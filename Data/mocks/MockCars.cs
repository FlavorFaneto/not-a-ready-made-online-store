using Shop1.Data.interfaces;
using Shop1.Data.Models;
using static System.Net.WebRequestMethods;

namespace Shop1.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        { 
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Toyota Mark II",
                        shortDesc = "Спортивный седан",
                        longDesc = "Четырёхдверный спортивный среднеразмерный седан, выпускавшийся компанией Toyota с 1968 по 2004 годы. Наименование Mark II использовалось компанией Toyota на протяжении нескольких десятилетий и первоначально использовалось в составе названия Toyota Corona Mark II.",
                        img = "https://a.d-cd.net/OrWuUu-7Rm8zjqZsYQBsylPE81o-960.jpg",
                        price = 450000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Пятидверный электромобиль производства американской компании Tesla. Прототип был впервые показан на Франкфуртском автосалоне в 2009 году; поставки электромобиля в США начались в июне 2012 года. ",
                        img = "https://www.zastavki.com/pictures/originals/2017_Silver_electric_Tesla_Model_S_111475_.jpg",
                        price = 550000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                   new Car
                    {
                        name = "BMW X1",
                        shortDesc = "Уютный, стильный автомобиль",
                        longDesc = "Компактный пятиместный кроссовер. Производство автомобиля началось на заводе в Лейпциге, Германия, в октябре 2009 года. Первое поколение было создано на платформе универсала BMW 3-й серии, отличалось шасси и электрогидравлическим усилителем руля. Второе поколение автомобилей стало переднеприводными, в дорогих комплектациях полноприводными.",
                        img = "https://rulikolesa.ru/wp-content/uploads/2017/06/maxresdefault-5.jpg",
                        price = 450000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                   new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Компактный электромобиль",
                        longDesc = "Электромобиль японского концерна Nissan, серийно выпускаемый с весны 2010 года. Мировая премьера состоялась на международном Токийском автосалоне в 2009 году. Заказы на модель японские и американские дилеры компании начали принимать 1 апреля 2010 года, сборка первых серийных экземпляров началась в Японии, затем с 2012 года Nissan развернул производство электромобилей Leaf на заводах в США, а с марта 2013 года - в Великобритании.",
                        img = "https://www.avtorinok.ru/storage/news/pics/2013/24725.jpg",
                        price = 350000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car>? getFavCars { get; set;  }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
        }
      

    }

