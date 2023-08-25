namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Email");
        }
    }
}
