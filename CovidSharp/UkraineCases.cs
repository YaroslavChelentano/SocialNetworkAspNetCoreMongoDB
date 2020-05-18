using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidSharp
{
    public class UkraineCases
    {
        public static string ShowCases()
        {
            CoronavirusData data = new CoronavirusData();
            var countOfCases = data.FromCountryConfirmed("Ukraine");
            return countOfCases;
        }
    }
}
