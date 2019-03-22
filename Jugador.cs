using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campionato.Championship
{
    class Jugador:Persona
    {
        private Equipo _equipe;
        private int _numero;
        private string _posicion;

        //Metodos Getter's y Setter's
        public  Equipo Equipe { get; set; }
        public int Numero { get; set; }
        public string Posicion { get; set; }
    }
}
