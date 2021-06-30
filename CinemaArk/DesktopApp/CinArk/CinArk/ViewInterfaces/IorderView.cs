using CinArk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.ViewInterfaces
{
    interface IorderView
    {
        orders order { get; set; }
        string errorMessage { get; set; }
    }
}
