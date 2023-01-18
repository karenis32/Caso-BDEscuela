using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int IdEvaluacion { get; set; }
        public int IdTipo { get; set; }
        public int IdEstudiante { get; set; }
        public int IdDetalle { get; set; }
        public int Nota { get; set; }

        public Estudiante estudiante { get; set; }
        public Detalle detalle { get; set;}
        public Tipo tipo { get; set; }
    }
}
