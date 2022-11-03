using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Base;
namespace Entidades
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public Habitacion(int id, string estado, int numero)
        {
            Id = id;
            Estado = estado;
            Numero = numero;
        }

        public Habitacion()
        {

        }
    }
}
