using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_HttpRequests
{
    internal class CountryInfo
    {
        string officialName;
        string capital;
        Double area;

        public CountryInfo(string officialName, string capital, Double area)
        {
            this.officialName = officialName;
            this.capital = capital;
            this.area = area;
        }
    }
}
