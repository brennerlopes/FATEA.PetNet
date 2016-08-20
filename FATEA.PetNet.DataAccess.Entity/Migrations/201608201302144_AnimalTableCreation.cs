namespace FATEA.PetNet.DataAccess.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimalTableCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Breed = c.String(),
                        Age = c.Int(nullable: false),
                        Color = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        IsCastrated = c.Boolean(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
