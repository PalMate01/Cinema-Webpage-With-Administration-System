using CinArk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.ViewInterfaces
{
    interface ImoviesView
    {
        movies movie { get; set; }
        string errorMessage { get; set; }
    }
}
