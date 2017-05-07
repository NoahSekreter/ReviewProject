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

        [Display(Name = "Destination")]
        public string Title { get; set; }

        public string Content { get; set; }
        public string Author { get; set; }

        [Display(Name = "Date")] [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        public DateTime PublishedDate { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}