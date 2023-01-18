namespace WindowsEducionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arregloTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carreras", newName: "Carrera");
            RenameTable(name: "dbo.Plans", newName: "Plan");
            RenameTable(name: "dbo.Planillas", newName: "Planilla");
            RenameTable(name: "dbo.Cursoes", newName: "Curso");
            RenameTable(name: "dbo.Detalles", newName: "Detalle");
            RenameTable(name: "dbo.Estadoes", newName: "Estado");
            RenameTable(name: "dbo.Evaluacions", newName: "Evaluacion");
            RenameTable(name: "dbo.Estudiantes", newName: "Estudiante");
            RenameTable(name: "dbo.Localidads", newName: "Localidad");
            RenameTable(name: "dbo.Profesors", newName: "Profesor");
            RenameTable(name: "dbo.Tipoes", newName: "Tipo");
            RenameTable(name: "dbo.Materias", newName: "Materia");
            AlterColumn("dbo.Carrera", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Plan", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Curso", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Estado", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Estudiante", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Estudiante", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Localidad", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesor", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesor", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Materia", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materia", "Nombre", c => c.String());
            AlterColumn("dbo.Profesor", "Apellido", c => c.String());
            AlterColumn("dbo.Profesor", "Nombre", c => c.String());
            AlterColumn("dbo.Localidad", "Nombre", c => c.String());
            AlterColumn("dbo.Estudiante", "Apellido", c => c.String());
            AlterColumn("dbo.Estudiante", "Nombre", c => c.String());
            AlterColumn("dbo.Estado", "Nombre", c => c.String());
            AlterColumn("dbo.Curso", "Nombre", c => c.String());
            AlterColumn("dbo.Plan", "Nombre", c => c.String());
            AlterColumn("dbo.Carrera", "Nombre", c => c.String());
            RenameTable(name: "dbo.Materia", newName: "Materias");
            RenameTable(name: "dbo.Tipo", newName: "Tipoes");
            RenameTable(name: "dbo.Profesor", newName: "Profesors");
            RenameTable(name: "dbo.Localidad", newName: "Localidads");
            RenameTable(name: "dbo.Estudiante", newName: "Estudiantes");
            RenameTable(name: "dbo.Evaluacion", newName: "Evaluacions");
            RenameTable(name: "dbo.Estado", newName: "Estadoes");
            RenameTable(name: "dbo.Detalle", newName: "Detalles");
            RenameTable(name: "dbo.Curso", newName: "Cursoes");
            RenameTable(name: "dbo.Planilla", newName: "Planillas");
            RenameTable(name: "dbo.Plan", newName: "Plans");
            RenameTable(name: "dbo.Carrera", newName: "Carreras");
        }
    }
}
