using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface ICarsService
    {
        IEnumerable<CarModel> GetCars();
    }
}
