using BusinessLogicLayer;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer
{
    public class DetailsController : IDetailsController
    {
        IDetailsService service = new DetailService();

        public IEnumerable<DetailViewModel> GetDetails()
        {
            var detailViewModel = from det in service.GetDetails()
                                   select new DetailViewModel() { Id = det.Id, Cars_Id = det.Cars_Id, Name = det.Name };
            return detailViewModel;
        }
    }
}
