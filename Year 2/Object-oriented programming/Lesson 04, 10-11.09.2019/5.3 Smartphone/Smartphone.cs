using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Smartphone {
    class Smartphone : IAccessInternet, ICall {
        private List<string> phoneNumbers;
        private List<string> browserURLS;

        public Smartphone()
            :this (new List<string>(), new List<string>()) { }

        public Smartphone(List<string> phoneNumbers, List<string> browserURLS) {
            this.phoneNumbers = phoneNumbers;
            this.browserURLS = browserURLS;
        }

        public void AddPhoneNumber(string newPhoneNumber) {
            phoneNumbers.Add(newPhoneNumber);
        }

        public void AddNewAddress(string newURL) {
            browserURLS.Add(newURL);
        }

        public string CallEveryone() {
            StringBuilder toReturn = new StringBuilder();

            foreach(var currPhoneNumber in phoneNumbers) {
                toReturn.AppendLine(Call(currPhoneNumber));
            }
            return toReturn.ToString().TrimEnd();
        }

        public string BrowseEverySite() {
            StringBuilder toReturn = new StringBuilder();

            foreach(var currSite in browserURLS) {
                toReturn.AppendLine(Browse(currSite));
            }
            return toReturn.ToString().TrimEnd();
        }

        public string Browse(string site) {
            if (site.Any(c => char.IsDigit(c))) return "Invalid URL!";

            return "Browsing: " + site;
        }

        public string Call(string number) {
            if (number.Any(c => !char.IsDigit(c))) return "Invalid number!";

            return "Calling... " + number;
        }
    }
}
