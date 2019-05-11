namespace KursMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enablerealesenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "RealeseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "RealeseDate", c => c.DateTime(nullable: false));
        }
    }
}
