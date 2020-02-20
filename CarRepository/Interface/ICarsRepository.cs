using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ICarsRepository
    {
        IEnumerable<Car> GetCars();
    }
}
