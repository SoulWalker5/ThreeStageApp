using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CarsService : ICarsService
    {
        ICarsRepository repository = new CarsRepository();

        public IEnumerable<CarModel> GetCarsModel()
        {
            var carsModels = from car in repository.GetCars()
                             select new CarModel() { Id = car.Id, Name = car.Name };
            return carsModels;
        }
    }
}
