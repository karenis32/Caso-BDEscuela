using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        [Key]
        public int IdPlanilla { get; set; }
        public int IdCarrera { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
        public int IdCurso { get; set; }
        public DateTime Fecha { get; set; }

        public List<Detalle> ListaDetalles { get; set;}

        public Curso curso { get; set; }

        public Carrera carrera { get; set; }

        public Materia materia { get; set; }

        public Profesor profesor { get; set; }
    }
}
