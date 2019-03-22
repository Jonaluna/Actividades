using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campionato.Championship
{
    class Equipo
    {
        //propiedades del equipo
        private int _id;
        private string _nombre;
        private string _entrenador;
        private string _comunidad;

        //enlace con jugador
        private List<Jugador> Jugadores = new List<Jugador>();


        //Metodos Getter's y Setter's
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public string Comunidad { get; set; }


    }
}
