using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Base;
using Microsoft.VisualBasic;
using Entidades;
using Entidades.Models.Base;




namespace Negocio
{
    public class AdmMedico
    {
        //declaracion de lista
        List<Medico> medicos;

        //funcion listar sin parametros
        public List<Medico>Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico() { Id = "0", Nombre = "gabriel", Apellido = "Lare", Domicilio = "san juan 1234", Telefono = "146548456", Email = "gabrielLare@gmail.com", Especialidad = "Medico Clinico", Matricula = "12334" });
            medicos.Add(new Medico() { Id = "1", Nombre = "rosana", Apellido = "perez", Domicilio = "san luis 1234", Telefono = "564545456", Email = "rosana@gmail.com", Especialidad = "Cardiologo", Matricula = "4567" });
            medicos.Add(new Medico() { Id = "2", Nombre = "mauricio", Apellido = "martinez", Domicilio = "santa fe 1234", Telefono = "787878456", Email = "mauricio@gmail.com", Especialidad = "Oftalmologo", Matricula = "789" });
            medicos.Add(new Medico() { Id = "3", Nombre = "lorenzo", Apellido = "gonzalez", Domicilio = "santiago del estero 1234", Telefono = "1254548456", Email = "lorenzo@gmail.com", Especialidad = "Endocrinologo", Matricula = "456" });
            medicos.Add(new Medico() { Id = "4", Nombre = "Martin", Apellido = "Maser", Domicilio = "salta 1554", Telefono = "153465846", Email = "martin@gmail.com", Especialidad = "Dentista", Matricula = "123" });


            return medicos;
        }

        //funcion listar con parametro
        public List<Medico> Listar(string especialidad)
        {
            List<Medico> lmedicos = new List<Medico> { };

            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == especialidad)
                {
                    lmedicos.Add(medico);
                }
            }
                return lmedicos;
        }

        public int Insertar(Medico medico)
        {
            return 0;
        }

        public int Eliminar(int id)
        {
            return 0;
        }

        public string TraerUno(int id)
        {
            return null;
        }

        public List<Medico> listar()
        {
            throw new NotImplementedException();
        }
    }
}
