using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero:Persona
    {
        public int Cuil { get; set; }
        public Enfermero(string nombre, string apellido, int id, string domicilio, string telefono, string email, int cuil) : base(nombre, apellido, id, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

          
    }
}
