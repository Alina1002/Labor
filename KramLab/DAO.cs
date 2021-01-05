using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KramLab
{
    public interface DAO
    {
        List<CounterParty> getCounterPartyes();
        CounterParty getCounterParty(int id);
        CounterParty createCounterParty(CounterParty a);
        bool deleteCounterParty(int id);
        bool updateCounterParty(CounterParty a);
    }
}