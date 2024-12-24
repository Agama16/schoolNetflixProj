using System;
using System.Collections.Generic;
using System.Text;
using agam.Utilities;
using System.Threading.Tasks;
using System.Linq;

namespace agam.Class
{
    class Movies
    {
        private string movieName;
        private DateTime releaseDate;
        private string description;
        private string movieGenre;
        private int ageLimit;
        private string producer;

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
        public DateTime ReleaseDate
        {
            set
            {
                releaseDate = value;
            }
            get
            {
                return this.releaseDate;
            }
        }
        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return this.description;
            }
        }
        public string MovieGenre
        {
            set
            {
                movieGenre = value;
            }
            get
            {
                return this.movieGenre;
            }
        }
        public int AgeLimit
        {
            set
            {
                ageLimit = value;
            }
            get
            {
                return this.ageLimit;
            }
        }
        public string Producer
        {
            set
            {
                if (ValidationUtilites.IsLegalName(value))
                    producer = value;
                else
                {
                    throw new Exception("this name is not valid");

                }
            }
            get
            {
                return this.producer;
            }
        }
    }
}
