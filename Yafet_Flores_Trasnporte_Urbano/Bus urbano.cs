using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Yafet_Flores_Trasnporte_Urbano
{
    public class Bus_urbano : Vehiculo
    {
        public int tarifakm;
        public string tipovehiculo;

        public Bus_urbano(string tipovehiculo, string placa , int pasajeros, int velmax, int kmreco, int tarifakm) : base(placa, pasajeros, velmax, kmreco)
        {
            this.tarifakm = tarifakm;
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
            Console.WriteLine($"El vehiculo recorrio una cantidad de {Kmreco}");
        }

        public override void calculartarifa()
        {
            int cost = Kmreco * tarifakm;
            Console.WriteLine($"El costo de la taria por viajar en este vehiculo es de: {cost}");
        }

    }

}
