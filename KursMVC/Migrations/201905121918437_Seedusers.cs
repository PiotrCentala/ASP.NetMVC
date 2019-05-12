namespace KursMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seedusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0cf66626-d800-440c-8bb1-337bc6b0eae7', N'manager@wp.pl', 0, N'AHDwJ5nLEtEgXyjSaYZCMChn2/6gmPTi6o5DTQ4ZYd94N+Z87Jn2CLQtKyOEuds4Ew==', N'ff3e8312-61ce-425b-bcf7-86805c51b405', NULL, 0, 0, NULL, 1, 0, N'manager@wp.pl')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f8bf01bb-8be3-4e6b-9c05-8172a1a96f97', N'wdad@gmail.com', 0, N'ACz4io8QIsXUDKU5LqsatPD8Hd3r90giJx6Z3QzKIeQbhxB4n2jkhUqSyetmr4+OxQ==', N'ff6418af-a47b-4130-bdd9-87d876a05e9e', NULL, 0, 0, NULL, 1, 0, N'wdad@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'94c4b03e-5c10-4eaa-9b86-6fc86cd8ac77', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0cf66626-d800-440c-8bb1-337bc6b0eae7', N'94c4b03e-5c10-4eaa-9b86-6fc86cd8ac77')

"
                );
        }
        
        public override void Down()
        {
        }
    }
}
