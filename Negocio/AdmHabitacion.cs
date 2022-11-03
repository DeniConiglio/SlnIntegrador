using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Models.Base;

namespace Negocio
{
    public class AdmHabitacion
    {

        List<Habitacion> habitaciones;
        public List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion() { Estado = "Libre", Id = 0, Numero = 12 });
            habitaciones.Add(new Habitacion() { Estado = "Ocupada", Id = 1, Numero = 20 });
            habitaciones.Add(new Habitacion() { Estado = "Libre", Id = 2, Numero = 3 });
            habitaciones.Add(new Habitacion() { Estado = "Libre", Id = 3, Numero = 10 });
            habitaciones.Add(new Habitacion() { Estado = "Ocupada", Id = 4, Numero = 25 });

            return habitaciones;
        }

        public List<Habitacion>Listar(string estado)
        {
            
            return null;
        }

        public int Insertar(Habitacion habitacion)
        {
            return 0;
        }

        public Habitacion TraerUno(int numero)
        {
            return null;
        }
    }
}
