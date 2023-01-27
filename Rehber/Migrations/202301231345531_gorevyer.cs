namespace Rehber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gorevyer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GorevYeris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        gorevyaptigiyer = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GorevYeris");
        }
    }
}
