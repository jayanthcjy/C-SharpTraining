namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class autoMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Location");
        }
    }
}
