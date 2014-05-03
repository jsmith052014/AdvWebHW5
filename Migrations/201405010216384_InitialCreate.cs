namespace SmithJessicaHW5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        LengthInMinutes = c.Int(nullable: false),
                        Format = c.String(),
                        Genre = c.String(),
                        Rating = c.Int(nullable: false),
                        IsFavorited = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleInitial = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Actors");
            DropTable("dbo.Movies");
        }
    }
}
