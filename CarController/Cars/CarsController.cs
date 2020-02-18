using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class CarsController : ICarsController
    {
        ICarsService service = new CarsService();

        public IEnumerable<CarViewModel> GetСarsViewModels()
        {
            var carsViewModel = from car in service.GetCarsModel()
                                 select new CarViewModel() { Id = car.Id, Name = car.Name };
            return carsViewModel;
        }
    }
}
