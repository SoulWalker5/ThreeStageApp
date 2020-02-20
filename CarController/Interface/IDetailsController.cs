using System.Collections.Generic;

namespace PresentationLayer
{
    public interface IDetailsController
    {
        IEnumerable<DetailViewModel> GetDetails();
    }
}
