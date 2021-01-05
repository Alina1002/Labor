using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KramLab
{
    public class MSSqlManager: DAO
    {
        public List<CounterParty> getCounterPartyes() { return null; }
        public CounterParty getCounterParty(int id) { return null; }
        public CounterParty createCounterParty(CounterParty a) { return null; }
        public bool deleteCounterParty(int id) { return true; }
        public bool updateCounterParty(CounterParty a) { return true; }
    }
}