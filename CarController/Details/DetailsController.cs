using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class DetailsController : IDetailsController
    {
        IDetailsService service = new DetailService();

        public IEnumerable<DetailViewModel> GetDetailViewModels()
        {
            var detailViewModel = from det in service.GetDetailsModel()
                                   select new DetailViewModel() { Id = det.Id, Cars_Id = det.Cars_Id, Name = det.Name };
            return detailViewModel;
        }
    }
}
