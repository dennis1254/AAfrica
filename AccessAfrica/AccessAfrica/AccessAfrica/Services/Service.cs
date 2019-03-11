using AccessAfrica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessAfrica.Services
{
    public class Service
    {
        public IList<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country{Name = "Nigeria" , Image="NGN.png", Currency = "NGN"},
                new Country{Name = "Ghana" , Image="gh.png", Currency = "GHS"}
            };
        }
    }
}
