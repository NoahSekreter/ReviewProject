namespace ReviewProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Author");
        }
    }
}
