using System;
using System.Collections.Generic;
using System.Text;
using agam.Utilities;
using System.Threading.Tasks;
using System.Linq;

namespace agam.Class
{
    class AccountTypes
    {
        private string typeName;
        private double charge;
        private int numOfUsers;

        public string TypeName
        {
            set
            {
                if (value == "Premium" || value == "Basic" || value == "Standard")
                    typeName = value;
                else
                {
                    throw new Exception("this account type does not exist");
                }
            }
            get
            {
                return this.typeName;
            }
        }
        public double Charge
        {
            set
            {
                    charge = value;
            }
            get
            {
                return this.charge;
            }
        }
        public int NumOfUsers
        {
            set
            {
                numOfUsers = value;
            }
            get
            {
                return this.numOfUsers;
            }
        }
    }
}

