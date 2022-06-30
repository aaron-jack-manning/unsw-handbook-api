using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNSW_Handbook_API
{
    class Subject
    {
        public string Code;
        public ushort UOC;
        public string Name;
        public string OfferingFaculty;
        public List<string> Exclusions;
        public List<string> OfferingTerms;
        public List<string> ConditionsOfEnrolment;

        public override string ToString()
        {
            string prettyString = "";

            prettyString += Code + " - " + Name + "\n";
            prettyString += OfferingFaculty + "\n";
            prettyString += "Units of Credit: " + UOC + "\n";
            prettyString += Exclusions.Count == 0 ? "Exclusions: None" : "Exclusions:\n" + Exclusions.Aggregate("", (state, element) => state + "- " + element + "\n");
            prettyString += "Offering Terms:\n" + OfferingTerms.Aggregate("", (state, element) => state + "- " + element + "\n");
            prettyString += ConditionsOfEnrolment.Count == 0 ? "Conditions of Enrolment: None" : "Conditions of Enrolment:\n" + ConditionsOfEnrolment.Aggregate("", (state, element) => state + "- " + element + "\n");

            return prettyString;
        }
    }
}
