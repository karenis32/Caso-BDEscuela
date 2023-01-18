﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Localidad")]
    public class Localidad
    {
        [Key]
        public int IdLocalidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        public List<Profesor> ListaProfesores { get; set; }
        public List<Estudiante> ListaEstudiantes { get; set; }

    }
}
