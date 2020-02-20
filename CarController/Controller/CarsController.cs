using BusinessLogicLayer;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer
{
    public class CarsController : ICarsController
    {
        ICarsService service = new CarsService();

        public IEnumerable<CarViewModel> GetСars()
        {
            var carsViewModel = from car in service.GetCars()
                                 select new CarViewModel() { Id = car.Id, Name = car.Name };
            return carsViewModel;
        }
    }
}
