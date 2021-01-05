using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KramLab
{
    public class CounterParty
    {
        public int id = -1;
        public string name = "";
        public string name_short = "";
        public string address_legal = "";
        public string address_fact = "";
        public string edrpou = "";
        public string IIN = "";
        public string ceo_name = "";
        public string ceo_name_rod = "";
        public string ceo_short_name = "";
        public string ceo_post = "";
        public string ceo_mandate = "";
        public string bankinfo = "";
        public bool isLaboratory = false;
        public bool isOrganization = false;
        public bool isBudgetOrganization = false;
        public bool VAT = false;
    }
}