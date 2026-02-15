using System;
using System.Collections.Generic;
using System.Text;

namespace Yafet_Flores_Trasnporte_Urbano
{
    public class Bici : Vehiculo
    {
        public int costenerkm;
        public string tipovehiculo;

        public Bici(string tipovehiculo, string placa, int pasajeros, int velmax, int kmreco, int costenerkm) : base(placa, pasajeros, velmax, kmreco)
        {
            this.costenerkm = costenerkm;
            this.tipovehiculo = tipovehiculo;
        }

        public override void Info()
        {
            Console.WriteLine($"Tipo del vehiculo: {tipovehiculo}");
            Console.WriteLine($"Placa del vehiculo: {Placa}");
            Console.WriteLine($"Capacidad de pasajeros: {Pasajeros}");
            Console.WriteLine($"Velocidad maxima: {Velmax}");
        }

        public void recorrer()
        {
            Console.WriteLine($"El vehiculo recorrio una cantidad de {Kmreco} kilometros");
        }

        public override void calculartarifa()
        {
            int cost = Kmreco * costenerkm;
            Console.WriteLine($"El costo de la taria por viajar en este vehiculo es de: {cost}");
        }
    }
}
