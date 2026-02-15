using System;
using System.Collections.Generic;
using System.Text;

namespace Yafet_Flores_Trasnporte_Urbano
{
    public abstract class Vehiculo
    {
        //Atributos para las clases hijas

        private string placa; // numero de placa del vehiculo
        private int pasajeros; // capacidad de estos
        private int velmax; // velocidad maxima del vehiculo
        private int kmreco; // cantidad de kilometros recorridos

        //Encapsulamiento 

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Pasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

        public int Velmax
        {
            get { return velmax; }
            set { velmax = value; }
        }

        public int Kmreco {
            get { return kmreco; }
            set { kmreco = value; }
        }

        //Constructor
        public Vehiculo (string placa, int pasajeros, int velmax, int kmreco)
        {
            Placa = placa;
            Pasajeros = pasajeros;
            Velmax = velmax;
            Kmreco = kmreco;
        }

        //Metodos
        public abstract void Info();
        public abstract void calculartarifa();
    }
}
