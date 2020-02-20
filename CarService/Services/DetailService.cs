using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class DetailService : IDetailsService
    {
        IDetailsRepository repository = new DetailsRepository();
        public IEnumerable<DetailModel> GetDetails()
        {
            var detailsModels = from detail in repository.GetDetails()
                                select new DetailModel() { Id = detail.Id, Cars_Id = detail.Cars_Id, Name = detail.Name };
            return detailsModels;
        }
    }
}
