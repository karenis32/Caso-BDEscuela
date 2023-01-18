namespace WindowsEducionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        IdCarrera = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdCarrera);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        IdPlan = c.Int(nullable: false, identity: true),
                        IdCarrera = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdPlan)
                .ForeignKey("dbo.Carreras", t => t.IdCarrera, cascadeDelete: true)
                .Index(t => t.IdCarrera);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        IdPlanilla = c.Int(nullable: false, identity: true),
                        IdCarrera = c.Int(nullable: false),
                        IdMateria = c.Int(nullable: false),
                        IdProfesor = c.Int(nullable: false),
                        IdCurso = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPlanilla)
                .ForeignKey("dbo.Carreras", t => t.IdCarrera, cascadeDelete: true)
                .ForeignKey("dbo.Cursoes", t => t.IdCurso, cascadeDelete: true)
                .ForeignKey("dbo.Profesors", t => t.IdProfesor, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.IdMateria, cascadeDelete: true)
                .Index(t => t.IdCarrera)
                .Index(t => t.IdMateria)
                .Index(t => t.IdProfesor)
                .Index(t => t.IdCurso);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        IdCurso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdCurso);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        IdDetalle = c.Int(nullable: false, identity: true),
                        IdPlanilla = c.Int(nullable: false),
                        IdEstado = c.Int(nullable: false),
                        estado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdDetalle)
                .ForeignKey("dbo.Estadoes", t => t.estado_Id)
                .ForeignKey("dbo.Planillas", t => t.IdPlanilla, cascadeDelete: true)
                .Index(t => t.IdPlanilla)
                .Index(t => t.estado_Id);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        IdEvaluacion = c.Int(nullable: false, identity: true),
                        IdTipo = c.Int(nullable: false),
                        IdEstudiante = c.Int(nullable: false),
                        IdDetalle = c.Int(nullable: false),
                        Nota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEvaluacion)
                .ForeignKey("dbo.Detalles", t => t.IdDetalle, cascadeDelete: true)
                .ForeignKey("dbo.Estudiantes", t => t.IdEstudiante, cascadeDelete: true)
                .Index(t => t.IdEstudiante)
                .Index(t => t.IdDetalle);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        IdEstudiante = c.Int(nullable: false, identity: true),
                        IdLocalidad = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Calle = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.IdEstudiante)
                .ForeignKey("dbo.Localidads", t => t.IdLocalidad, cascadeDelete: true)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Localidads",
                c => new
                    {
                        IdLocalidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        IdProfesor = c.Int(nullable: false, identity: true),
                        IdLocalidad = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.IdProfesor)
                .ForeignKey("dbo.Localidads", t => t.IdLocalidad, cascadeDelete: true)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        IdMateria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdMateria);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        IdTipo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdTipo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planillas", "IdMateria", "dbo.Materias");
            DropForeignKey("dbo.Detalles", "IdPlanilla", "dbo.Planillas");
            DropForeignKey("dbo.Profesors", "IdLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Planillas", "IdProfesor", "dbo.Profesors");
            DropForeignKey("dbo.Estudiantes", "IdLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Evaluacions", "IdEstudiante", "dbo.Estudiantes");
            DropForeignKey("dbo.Evaluacions", "IdDetalle", "dbo.Detalles");
            DropForeignKey("dbo.Detalles", "estado_Id", "dbo.Estadoes");
            DropForeignKey("dbo.Planillas", "IdCurso", "dbo.Cursoes");
            DropForeignKey("dbo.Planillas", "IdCarrera", "dbo.Carreras");
            DropForeignKey("dbo.Plans", "IdCarrera", "dbo.Carreras");
            DropIndex("dbo.Profesors", new[] { "IdLocalidad" });
            DropIndex("dbo.Estudiantes", new[] { "IdLocalidad" });
            DropIndex("dbo.Evaluacions", new[] { "IdDetalle" });
            DropIndex("dbo.Evaluacions", new[] { "IdEstudiante" });
            DropIndex("dbo.Detalles", new[] { "estado_Id" });
            DropIndex("dbo.Detalles", new[] { "IdPlanilla" });
            DropIndex("dbo.Planillas", new[] { "IdCurso" });
            DropIndex("dbo.Planillas", new[] { "IdProfesor" });
            DropIndex("dbo.Planillas", new[] { "IdMateria" });
            DropIndex("dbo.Planillas", new[] { "IdCarrera" });
            DropIndex("dbo.Plans", new[] { "IdCarrera" });
            DropTable("dbo.Tipoes");
            DropTable("dbo.Materias");
            DropTable("dbo.Profesors");
            DropTable("dbo.Localidads");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Detalles");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Planillas");
            DropTable("dbo.Plans");
            DropTable("dbo.Carreras");
        }
    }
}
