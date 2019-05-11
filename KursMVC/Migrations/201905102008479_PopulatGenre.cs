namespace KursMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Sci-Fi')");

        }
        
        public override void Down()
        {
        }
    }
}
