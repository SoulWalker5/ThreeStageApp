﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public interface IDetailsController
    {
        IEnumerable<DetailViewModel> GetDetailViewModels();
    }
}
