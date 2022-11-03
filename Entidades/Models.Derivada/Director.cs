using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Base;

namespace Entidades
{
    public class Director:Medico
    {
        public string Posgrado { get; set; }
        public Director(string nombre, string apellido, int id, string domicilio, string telefono, string email, string especialidad, string matricula, string posgrado) : base(nombre, apellido, id, domicilio, telefono, email,especialidad,matricula)
        {

            Posgrado = posgrado;
        }
        public Director() { }
    }
}
