using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEducionIT.Models;

namespace WindowsEducionIT.Data
{
    public class DBWindowsEducionIT: DbContext
    {
        public DBWindowsEducionIT() : base("KeyDB") { }

        public DbSet<Carrera> carreras { get; set; }
        public DbSet<Curso> curso { get; set; }
        public DbSet<Detalle> detalles { get; set; }
        public DbSet<Estado> estado { get; set; }
        public DbSet<Estudiante> estudiantes { get; set; }
        public DbSet<Evaluacion> evalaciones { get; set;}
        public DbSet<Localidad> localidad { get; set; }
        public DbSet<Materia> materia { get; set; }
        public DbSet<Plan> planes { get; set; }
        public DbSet<Planilla> planilla { get; set; }
        public DbSet<Profesor> profesores { get; set; }
        public DbSet<Tipo> tipos { get; set; } 

    }
}
