using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNSW_Handbook_API
{
    class Program
    {
        public string Name;
        public string Description;
        public string AwardTitle;
        public List<string> Keywords;


        public override string ToString()
        {
            string prettyString = "";

            prettyString += Name + "\n";
            prettyString += Description + "\n";
            prettyString += "Award Title: " + AwardTitle + "\n";
            prettyString += Keywords.Count == 0 ? "Keywords: None" : "Keywords:\n" + Keywords.Aggregate("", (state, element) => state + "- " + element + "\n");

            return prettyString;
        }

    }
}
