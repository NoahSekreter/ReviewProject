using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class ReviewProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ReviewProjectContext() : base("name=ReviewProjectContext")
        {
        }

        public System.Data.Entity.DbSet<ReviewProject.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<ReviewProject.Models.Category> Categories { get; set; }
    }
}
