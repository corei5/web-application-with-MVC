namespace web_application_with_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Albums", "Year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "Year", c => c.String());
        }
    }
}
