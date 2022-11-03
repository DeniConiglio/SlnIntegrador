using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public int NumHClinica { get; set; }
        public Paciente(string nombre, string apellido, int id, string domicilio, string telefono, string email,int numHClinica): base(nombre, apellido, id, domicilio,telefono,email)
        {
            NumHClinica=numHClinica;
        }

        public Paciente()
        {
        }

        
        
    }
}
