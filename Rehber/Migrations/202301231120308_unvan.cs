namespace Rehber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unvan : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Kategoris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
