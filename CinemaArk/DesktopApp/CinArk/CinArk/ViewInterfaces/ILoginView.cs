using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.ViewInterfaces
{
    public interface ILoginView
    {
        string username { get; }
        string pass { get; }
        string errUsername { set; }
        string errPass { set; }
    }
}
