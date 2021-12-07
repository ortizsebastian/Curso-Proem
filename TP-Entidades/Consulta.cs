using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Entidades
{
    public class Consulta
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public string Resultado { get; set; }
        public bool Estado { get; set; }
        public Consulta()
        {
            Estado = true;
        }
        public Consulta(Paciente Paciente, Medico Medico)
        {
            this.Paciente = Paciente;
            this.Medico = Medico;
            Resultado = null;
            Estado = true;
        }
    }
}
