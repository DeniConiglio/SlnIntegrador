using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Base;
using Microsoft.VisualBasic;

namespace Negocio
{
    public class AdmPaciente
    {
        List<Paciente> pacientes;

        public List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Id = "0", Nombre = "Roberto", Apellido = "Peralta", Domicilio = " rivadavia 1234", Email = "peralta12@gmail.com", NumHClinica = 1515, Telefono = "234564545" });
            pacientes.Add(new Paciente() { Id = "1", Nombre = "Rogelio", Apellido = "Celta", Domicilio = " dorrego 2234", Email = "Rogelio2@gmail.com", NumHClinica = 2555, Telefono = "45454515345" });
            pacientes.Add(new Paciente() { Id = "2", Nombre = "Ramon", Apellido = "Boit", Domicilio = " matheu 5234", Email = "Ramon@gmail.com", NumHClinica = 7887, Telefono = "546851341561" });
            pacientes.Add(new Paciente() { Id = "3", Nombre = "Roque", Apellido = "Licursi", Domicilio = " luro 2134", Email = "Roque@gmail.com", NumHClinica = 9994, Telefono = "4651358646" });
            pacientes.Add(new Paciente() { Id = "4", Nombre = "Rosa", Apellido = "Eliser", Domicilio = " colon 2934", Email = "Rosa@gmail.com", NumHClinica = 9204, Telefono = "4532542313" });


            return pacientes;
        }

        public int Insertar(Paciente paciente)
        {
            return 0;
        }

        public int Eliminar(int id)
        {
            return 0;
        } 

        public string TraerUno(int numHClinica)
        {
            return null;
        }
    }
}
