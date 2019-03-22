using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campionato.Championship
{
    class Cancha
    {
        //Propiedades de la clase
        private int _id;
        private string _tipo; //soccer, futbol 7
        private string _nombre;
        private string _ubicacion;

        //Metodos Getter's y Setter's
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
    }
}
