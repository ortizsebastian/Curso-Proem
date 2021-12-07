using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Entidades
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public int PacientesAtendidos { get; set; }
        public Medico() : base() { }
        public Medico(string Nombre, string Apellido, string Especialidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Especialidad = Especialidad;
            PacientesAtendidos = 0;
            Estado = true;
        }
    }
}
