using CinArk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.ViewInterfaces
{
    interface IitemView
    {
        items item { get; set; }
        string errorMessage { get; set; }
    }
}
