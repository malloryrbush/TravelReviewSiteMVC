using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string City { get; set; }
        public string Attractions { get; set; }
        public string Hotels { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}