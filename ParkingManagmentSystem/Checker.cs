using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagmentSystem
{
    class Checker:Person
    {
        private string GeneratedUserID;

        public Checker()
        {
        }

        public Checker(string name, int nid, string phone, string userID, string password, string position, float salary) : base(name, nid, phone, userID, password, position, salary)
        {

        }
        public string GeneratedUserID1 { get => GeneratedUserID; set => GeneratedUserID = value; }
    }
}
