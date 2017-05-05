using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Location")]
        public string Title { get; set; }

        public string Content { get; set; }

        [Display(Name = "Date")] [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        public DateTime PublishedDate { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}