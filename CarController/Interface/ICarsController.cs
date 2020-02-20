using System.Collections.Generic;

namespace PresentationLayer
{
    public interface ICarsController
    {
        IEnumerable<CarViewModel> GetСars();
    }
}
