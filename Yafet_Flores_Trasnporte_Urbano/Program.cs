using Yafet_Flores_Trasnporte_Urbano;

Console.WriteLine("Yafet Alessandro Flores Zavala 20251900155");
Console.WriteLine("************* Ejemplo con 10 kilometros ******************");
//Ejemplo del bus
Bus_urbano bus1 = new("Bus urbano", "DTO-2015",25,80,10,80); //Tipo de vehiculo, placa, capacidad de pasajeros, velmax, kmrecorridos, tarifa/km
bus1.Info();
bus1.recorrer();
bus1.calculartarifa();
Console.WriteLine("");

Taxi tax1 = new("Taxi", "UR-Q1978",4,100,10,35,60); //Tipo de vehiculo, placa, capacidad de pasajeros, velmax, kmrecorridos, tarifabase, tarifa/km
tax1.Info();
tax1.recorrer();
tax1.calculartarifa();
Console.WriteLine("");

Bici bic1 = new("Bici Electrica","VNW02-12",1,35,10,30); //Tipo de vehiculo, placa, capacidad de pasajeros, velmax, kmrecorridos, coste de energia/km
bic1.Info();
bic1.recorrer();
bic1.calculartarifa();
Console.WriteLine("");

Console.WriteLine("************* Ejemplo con 30 kilometros ******************");
//Ejemplo del bus
Bus_urbano bus2 = new("Bus urbano", "DTO-2015", 25, 80, 30, 80); //Tipo de vehiculo, placa, capacidad de pasajeros, velmax, kmrecorridos, tarifa/km
bus2.Info();
bus2.recorrer();
bus2.calculartarifa();
Console.WriteLine("");

Taxi tax2 = new("Taxi", "UR-Q1978", 4, 100, 30, 35, 60); //Tipo de vehiculo, placa, capacidad de pasajeros, velmax, kmrecorridos, tarifabase, tarifa/km
tax2.Info();
tax2.recorrer();
tax2.calculartarifa();
Console.WriteLine("");

Bici bic2 = new("Bici Electrica", "VNW02-12", 1, 35, 30, 30); //Tipo de vehiculo, placa, capacidad de pasajeros, velmax, kmrecorridos, coste de energia/km
bic2.Info();
bic2.recorrer();
bic2.calculartarifa();
