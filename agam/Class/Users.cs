using System;
using System.Collections.Generic;
using System.Text;

namespace agam.Class
{
    class Users
    {
        private string userName;
        private DateTime dateOfBirth;
        private int accountNumber;
        public string UserName
        {
            set
            {
                userName = value;
            }
            get
            {
                return this.userName;
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
        public int AccountNum
        {
            set
            {
                accountNumber = value;
            }
            get
            {
                return this.accountNumber;
            }
        }
    }
}
