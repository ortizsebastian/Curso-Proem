using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Entidades
{
    public class Paciente : Persona
    {
        public string DNI { get; set; }
        public string Cobertura { get; set; }
        public int Edad { get; set; }
        public string Requiere { get; set; }
        public Paciente() : base() { }
        public Paciente(string Nombre, string Apellido, string DNI, string Cobertura, int Edad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
            this.Cobertura = Cobertura;
            this.Edad = Edad;
            Requiere = null;
            Estado = true;
        }
    }
}
