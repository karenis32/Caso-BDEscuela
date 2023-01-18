﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table ("Carrera")]
    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        public List<Planilla> ListaPlanillas { get; set; }

        public List<Plan> ListaPlan { get; set; }
    }
}
