﻿using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public string Matricula { get; set; }

       
        public Medico(string nombre, string apellido, int id, string domicilio, string telefono, string email, string especialidad, string matricula) : base (nombre, apellido, id, domicilio, telefono, email)
        {
           
            Especialidad = especialidad;
            Matricula = matricula;
        }
        public Medico() { }

        public static List<Medico> listar()
        {
            throw new NotImplementedException();
        }
    }
}
