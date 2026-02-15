using Yafet_Flores_Trasnporte_Urbano;

Console.WriteLine("Yafet Alessandro Flores Zavala 20251900155");
Console.WriteLine("************* Ejemplo con 10 kilometros ******************");
Bus_urbano bus1 = new("Bus urbano", "DTO2015",25,80,10,50);
bus1.Info();
bus1.recorrer();
bus1.calculartarifa();
