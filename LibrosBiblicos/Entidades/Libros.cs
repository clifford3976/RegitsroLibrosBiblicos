﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LibrosBiblicos.Entidades
{
    public class Libros
    {
        [Key]
        public int LibroId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Siglas { get; set; }
        public string Tipo { get; set; }


        public Libros()
        {
            LibroId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Siglas = string.Empty;
            Tipo = string.Empty;
        }
    }
}
