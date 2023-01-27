namespace Rehber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unvani : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Unvans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Unvani = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Unvans");
        }
    }
}
