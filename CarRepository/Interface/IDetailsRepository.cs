using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IDetailsRepository
    {
        IEnumerable<Detail> GetDetails();

    }
}
