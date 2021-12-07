using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public Persona()
        {
            Estado = true;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
