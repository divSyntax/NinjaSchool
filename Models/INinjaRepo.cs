using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaSchool.Models
{
    public interface INinjaRepo
    {
         IEnumerable<Ninja> getallNinjas();
         Ninja getNinja(int Id);

    }
}
