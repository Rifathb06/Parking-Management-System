using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagmentSystem
{
    class Manager: Person
    {
        private string GeneratedUserID;

        public Manager()
        {

        }
        public Manager(string name, int nid, string phone, string userID, string password, string position, float salary): base(name, nid, phone, userID, password, position, salary)
        {

        }


        public string GeneratedUserID1 { get => GeneratedUserID; set => GeneratedUserID = value; }
    }
}
