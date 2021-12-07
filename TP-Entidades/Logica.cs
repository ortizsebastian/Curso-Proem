using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Entidades
{
    public static class Logica
    {
        public static List<Paciente> ListaPaciente { get; set; }
        public static List<Medico> ListaMedico { get; set; }
        public static List<Consulta> ListaConsulta { get; set; }
        static Logica()
        {
            ListaPaciente = new List<Paciente>();
            ListaMedico = new List<Medico>();
            ListaConsulta = new List<Consulta>();
        }
        public enum Resultado
        {
            Derivación,
            Estudios,
            Internación,
            Cirugía,
            Tratamiento,
            Urgencia,
        }

        public static void AgregarPaciente(Paciente paciente)
        {
            ListaPaciente.Add(paciente);
        }
        public static void AgregarMedico(Medico medico) 
        {
            ListaMedico.Add(medico);   
        }
        public static List<string> MostrarEspecialidades()
        {
            List<string> listaEspecialidad = new();
            foreach (var item in ListaMedico)
            {
                if(!listaEspecialidad.Any(x => x.Contains(item.Especialidad)))
                    listaEspecialidad.Add(item.Especialidad);
            }
            return listaEspecialidad;
        }
        public static List<string> MostrarNombres()
        {
            List<string> listaNombre = new();
            foreach (var item in ListaMedico)
            {
                    listaNombre.Add(item.Nombre);
            }
            return listaNombre;
        }
        public static List<Consulta> MostrarConsultas(bool estado)
        {
            List<Consulta> listaConsulta = new();
            listaConsulta = ListaConsulta.FindAll(x => x.Estado == estado);
            return listaConsulta;
        }

        /// <summary>
        /// Busca las especialidades mas solicitadas en base a la cantidad de pacientes atendidos.
        /// Previamente verifica si hay pacientes atendidos, si no devuelve null.
        /// </summary>
        /// <returns>La lista con la/las especialidades con mayor cantidad de pacientes atendidos.</returns>
        public static List<string> EspecialidadMasSolicitada()
        {
            if (ListaConsulta.Find(x => x.Estado == false) == null)
                return null;

            List<string> listaEspecialidades = MostrarEspecialidades();
            int[] cantidad = new int[listaEspecialidades.Count];
            int index = 0;

            foreach (var item in ListaMedico)
            {
                if (item.PacientesAtendidos > 0)
                {
                    index = listaEspecialidades.FindIndex(x => x.Contains(item.Especialidad));
                    cantidad[index] += item.PacientesAtendidos;
                }
            }

            List<string> especialidades = new();
            int valorMax = cantidad.Max();
            index = cantidad.ToList().IndexOf(valorMax);

            for (int i = 0; i < cantidad.Length; i++)
            {
                if (valorMax == cantidad[i])
                {
                    valorMax = cantidad[0];
                    especialidades.Add(listaEspecialidades[i]);
                }
            }
            return especialidades;
        }

        /// <summary>
        /// Busca el primer paciente cargado en la lista.
        /// Busca el médico solicitado según los parámetros recibidos.
        /// Crea un nuevo objeto consulta (con el médico y el paciente) y lo agrega a la lista.
        /// </summary>
        /// <param name="especialidad"></param>
        /// <param name="nombre"></param>
        public static void NuevaConsulta(string especialidad, string nombre)
        {
            Paciente paciente = new();
            paciente = ListaPaciente.Find(x => x.Estado == true && (x.Requiere == null || x.Requiere == especialidad));
            paciente.Estado = false;

            Medico medico = new();
            medico = ListaMedico.Find(x => x.Estado == true && (x.Especialidad == especialidad || x.Nombre == nombre));
            medico.Estado = false;

            Consulta consulta = new(paciente, medico);
            ListaConsulta.Add(consulta);
        }

        /// <summary>
        /// Recibe un objeto Consulta, realiza una busqueda en las listas y finaliza los estados. 
        /// Al médico le suma 1 en la cantidad de pacientes atendidos.
        /// A la consulta le asigna el resultado recibido por parámetro.
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="resultado"></param>
        public static void FinalizarConsulta(Consulta consulta, string resultado)
        {
            ListaMedico.Find(x => x == consulta.Medico).Estado = true; 
            ListaMedico.Find(x => x == consulta.Medico).PacientesAtendidos++; 

            ListaPaciente.Find(x => x == consulta.Paciente).Estado = false; 

            ListaConsulta.Find(x => x == consulta).Estado = false; 
            ListaConsulta.Find(x => x == consulta).Resultado = resultado; 
        }

        /// <summary>
        /// Busca un médico disponible según los parámetros recibidos.
        /// Si lo encuentra crea una Nueva Consulta.
        /// Si no lo encuentra toma 3 caminos diferentes.
        /// Médico no disponible, especialidad no disponible o no hay mas pacientes para atender.
        /// </summary>
        /// <param name="especialidad"></param>
        /// <param name="nombre"></param>
        /// <returns>Un string con un mensaje del resultado obtenido.</returns>
        public static string MedicoDisponible(string especialidad, string nombre)
        {
            Medico medico = new();
            medico = ListaMedico.Find(x => x.Estado == true && (x.Especialidad == especialidad || x.Nombre == nombre));

            Paciente paciente = new();
            paciente = ListaPaciente.Find(x => x.Estado == true && (x.Requiere == null || x.Requiere == especialidad));

            StringBuilder sb = new();

            if (medico != null && paciente != null)
            {
                NuevaConsulta(especialidad, nombre);
                sb.Append($"El paciente {paciente.Apellido} será atendido por el {medico.Especialidad}, {medico.Nombre} {medico.Apellido}.");
            }
            else if (medico == null)
            {
                if(especialidad == null)
                {
                    paciente.Requiere = ListaMedico.Find(x => x.Nombre == nombre).Especialidad;
                    sb.Append($"El médico {nombre} no esta disponible, el paciente {paciente.Apellido} será asignado a la lista de espera de los {paciente.Requiere}s.");
                }
                else
                {
                    paciente.Requiere = especialidad;
                    sb.Append($"No hay {especialidad}s disponibles, el paciente {paciente.Apellido} será asignado a la lista de espera de dicha especialidad.");
                }
            }
            else
            {
                sb.Append("No hay pacientes en la lista de espera.");
            }
            return sb.ToString();
        }
    }
}
