using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campionato.Championship
{
    class Persona
    {
        protected int _id;
        protected string _nombre;
        protected string _apellidos;
        protected DateTime _fechaNacimiento;

        //Metodos Getter's y Setter's
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
