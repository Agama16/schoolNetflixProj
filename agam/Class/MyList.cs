using System;
using System.Collections.Generic;
using System.Text;
using agam.Utilities;
using System.Threading.Tasks;
using System.Linq;

namespace agam.Class
{
    class MyList
    {
        private string userName;
        private string movieName;
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
        public string MovieName
        {
            set
            {
                movieName = value;
            }
            get
            {
                return this.movieName;
            }
        }
    }
}
