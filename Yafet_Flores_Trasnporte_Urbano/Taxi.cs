using System;
using System.Collections.Generic;
using System.Text;

namespace Yafet_Flores_Trasnporte_Urbano
{
    public class Taxi : Vehiculo
    {
        public int tarifakm;
        public int tarifabase;
        public string tipovehiculo;

        public Taxi (string tipovehiculo, string placa, int pasajeros, int velmax, int kmreco, int tarifabase,int tarifakm) : base(placa, pasajeros, velmax, kmreco)
        {
            this.tarifabase = tarifabase;
            this.tipovehiculo = tipovehiculo;
            this.tarifakm = tarifakm;
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
            int cost = tarifabase + (Kmreco * tarifakm);
            Console.WriteLine($"El costo de la taria por viajar en este vehiculo es de: {cost}");
        }

    }
}
