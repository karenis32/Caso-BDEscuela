namespace WindowsEducionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profesors", "IdLocalidad", "dbo.Localidads");
            DropIndex("dbo.Profesors", new[] { "IdLocalidad" });
            AlterColumn("dbo.Profesors", "IdLocalidad", c => c.Int());
            CreateIndex("dbo.Evaluacions", "IdTipo");
            CreateIndex("dbo.Profesors", "IdLocalidad");
            AddForeignKey("dbo.Evaluacions", "IdTipo", "dbo.Tipoes", "IdTipo", cascadeDelete: true);
            AddForeignKey("dbo.Profesors", "IdLocalidad", "dbo.Localidads", "IdLocalidad");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profesors", "IdLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Evaluacions", "IdTipo", "dbo.Tipoes");
            DropIndex("dbo.Profesors", new[] { "IdLocalidad" });
            DropIndex("dbo.Evaluacions", new[] { "IdTipo" });
            AlterColumn("dbo.Profesors", "IdLocalidad", c => c.Int(nullable: false));
            CreateIndex("dbo.Profesors", "IdLocalidad");
            AddForeignKey("dbo.Profesors", "IdLocalidad", "dbo.Localidads", "IdLocalidad", cascadeDelete: true);
        }
    }
}
