using NinjaSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaSchool
{
    public class NinjaImplementation : INinjaRepo
    {
        List<Ninja> ninjaList;

        public NinjaImplementation()
        {
            ninjaList = new List<Ninja>()
            {
                new Ninja(){Name="Uzammaki, Naruto", Level="Genen", Id=1, Power=100},
                new Ninja(){Name="Uchiha, Sauske", Level="Genen", Id=2, Power=100},
                new Ninja(){Name="Haruno, Sakura", Level="Genen", Id=3, Power=100}
            };
        }

        public IEnumerable<Ninja> getallNinjas()
        {
            return ninjaList;
        }

        public Ninja getNinja(int Id)
        {
            return ninjaList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
