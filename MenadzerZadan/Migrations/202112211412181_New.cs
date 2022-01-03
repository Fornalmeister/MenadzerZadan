namespace MenadzerZadan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaskModels", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.TaskModels", "Description", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaskModels", "Description", c => c.String());
            AlterColumn("dbo.TaskModels", "Name", c => c.String());
        }
    }
}
