using System;
using System.Collections.Generic;
using System.Text;
using agam.Utilities;
using System.Threading.Tasks;
using System.Linq;

namespace agam.Class
{
    public class Accounts
    {
        private string id;
        private string name;
        private string phoneNumber;
        private DateTime dateOfBirth;
        private string creditCard;
        private string password;
        private string accountType;
        private string accountNum;
        private double charge;
       

        public string Id
        {
            set
            {
                if (ValidationUtilites.IsLegalId(value))
                {
                    id = value;
                }
                else
                {
                    throw new Exception("the id is not valid");
                }
            }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return this.name;
            }
        }
        public string Password
        {
            set
            {
                    password = value;
            }
            get
            {
                return this.password;
            }
        }
        public string PhoneNumber
        {
            set
            {
                if(ValidationUtilites.IsLegalPhonNum(value))
                    phoneNumber= value;
                else
                {
                    throw new Exception("the phone number is not valid");
                }
            }
            get
            {
                return this.phoneNumber;
            }
        }
        public DateTime DateOfBirth
        {
            set
            {
                    dateOfBirth = value;
            }
            get
            {
                return this.dateOfBirth;
            }
        }
        public string CreditCard
        {
            set
            {
                if(ValidationUtilites.IsLegalCNumberAmericanexpress(value)||ValidationUtilites.IsLegalCNumberVisa(value))
                    creditCard = value;
                else
                {
                    throw new Exception("this credit card number is not valid");
                }
            }
            get
            {
                return this.creditCard;
            }
        }
        public string AccountType
        {
            set
            {
                if (value == "Premium" || value == "Basic" || value == "Standard")
                    accountType = value;
                else
                {
                    throw new Exception("this account type does not exist");
                }
            }
            get
            {
                return this.accountType;
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
        public string AccountNum
        {
            set
            {
                if (ValidationUtilites.IsLegalIdNum(value))
                    accountNum = value;
                else
                {
                    throw new Exception("this account type does not exist");
                }
            }
            get
            {
                return this.accountNum;
            }
        }
    }
        
}
