using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface IDetailsService
    {
        IEnumerable<DetailModel> GetDetailsModel();
    }
}