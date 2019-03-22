using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campionato.Modelo.Cinema
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLLena;

        private Asiento[] asiento = new Asiento[200];

        public Sala()
        {
            _nombre = "A";

            for (int i=0; i <=199; i++)
            {
                asiento[i] = new Asiento();
                asiento[i].Numero = i + 1;
            }

            asiento[0] = new Asiento();
            _capacidad = 200;
            _estaLLena = false;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool EstaLLena { get; set; }
    }
}
