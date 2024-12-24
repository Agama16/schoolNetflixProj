using System;
using System.Collections.Generic;
using System.Text;
using agam.Utilities;
using System.Threading.Tasks;
using System.Linq;
namespace agam.Class
{
    class TvShows
    {
        private string tvShow;
        private DateTime releaseDate;
        private string producer;
        private int ageLimit;
        private int seasons;
        private string genre;
        private string description;
        public string TvShow
        {
            set
            {
                tvShow = value;
            }
            get
            {
                return this.tvShow;
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
        public string Producer
        {
            set
            {
                producer = value;
            }
            get
            {
                return this.producer;
            }
        }
        public string Genre
        {
            set
            {
               genre = value;
            }
            get
            {
                return this.genre;
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
        public int Seasons
        {
            set
            {
                seasons = value;
            }
            get
            {
                return this.seasons;
            }
        }
    }
}
