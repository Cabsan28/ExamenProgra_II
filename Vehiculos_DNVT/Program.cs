using Esquema_DNVT;
using System;


class Program
{
    static void Main(string[] args)
    {

        Auto auto = new Auto
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            AñoFabricacion = 2020,
            NumeroSerie = "3FA6P0G73DR173482",
            NumeroPuertas = 4
        };

        Console.WriteLine("\n");
        Console.WriteLine(auto.Conducir());

        Console.WriteLine("\nMarca: " + auto.Marca);
        Console.WriteLine("Modelo: " + auto.Modelo);
        Console.WriteLine("Año de Fabricación: " + auto.AñoFabricacion);
        Console.WriteLine("Numero de Serie: " + auto.NumeroSerie);
        Console.WriteLine("Número de puertas: " + auto.NumeroPuertas);

        

        Console.WriteLine("\nEl tipo de licencia requerido para este automóvil es: " + auto.TipoLicencia());

        Moto moto = new Moto
        {
            Marca = "Yamaha",
            Modelo = "R6",
            AñoFabricacion = 2019,
            NumeroSerie = "JM3KE2DY3G0654923",
            Transmision = "Manual"
        };

        Console.WriteLine("\n");
        Console.WriteLine(moto.Conducir());

        Console.WriteLine("\nMarca: " + moto.Marca);
        Console.WriteLine("Modelo: " + moto.Modelo);
        Console.WriteLine("Año de Fabricación: " + moto.AñoFabricacion);
        Console.WriteLine("Numero de Serie: " + moto.NumeroSerie);
        Console.WriteLine("Transmisión: " + moto.Transmision);


        
        Console.WriteLine("\nEl tipo de licencia requerido para esta motocicleta es: " + moto.TipoLicencia());

        Camion camion = new Camion
        {
            Marca = "Volvo",
            Modelo = "FH16",
            AñoFabricacion = 2018,
            NumeroSerie = "1G1ZT52815F313168",
            CapacidadCarga = 50
        };
        Console.WriteLine("\n");
        Console.WriteLine(camion.Conducir());

        Console.WriteLine("\nMarca: " + camion.Marca);
        Console.WriteLine("Modelo: " + camion.Modelo);
        Console.WriteLine("Año de Fabricación: " + camion.AñoFabricacion);
        Console.WriteLine("Numero de Serie: " + camion.NumeroSerie);
        Console.WriteLine("Capacidad de carga: " + camion.CapacidadCarga + " toneladas");

        

        Console.WriteLine("\nEl tipo de licencia requerido para este camión es: " + camion.TipoLicencia());

        Furgon furgon = new Furgon
        {
            Marca = "Scania",
            Modelo = "Serie R",
            AñoFabricacion = 2016,
            NumeroSerie = "3N1CE2CP4HL354701",
            tamañoContenedor = 75
        };

        Console.WriteLine("\n");
        Console.WriteLine(furgon.Conducir());

        Console.WriteLine("\nMarca: " + furgon.Marca);
        Console.WriteLine("Modelo: " + furgon.Modelo);
        Console.WriteLine("Año de Fabricación: " + furgon.AñoFabricacion);
        Console.WriteLine("Numero de Serie: " + furgon.NumeroSerie);
        Console.WriteLine("Altura de contenedor: " + furgon.tamañoContenedor + " pies de alto");

        

        Console.WriteLine("\nEl tipo de licencia requerido para este furgón es: " + furgon.TipoLicencia());

        Cuatrimoto cuatrimoto = new Cuatrimoto
        {
            Marca = "Honda",
            Modelo = "TRX450R",
            AñoFabricacion = 2017,
            NumeroSerie = "5TDYK3DCXBS127535",
            materialParrilla = "Hierro"
        };

        Console.WriteLine("\n");
        Console.WriteLine(cuatrimoto.Conducir());

        Console.WriteLine("\nMarca: " + cuatrimoto.Marca);
        Console.WriteLine("Modelo: " + cuatrimoto.Modelo);
        Console.WriteLine("Año de Fabricación: " + cuatrimoto.AñoFabricacion);
        Console.WriteLine("Numero de Serie: " + cuatrimoto.NumeroSerie);
        Console.WriteLine("Material de la Parrilla: " + cuatrimoto.materialParrilla );

       

        Console.WriteLine("\nEl tipo de licencia requerido para esta cuatrimoto es: " + cuatrimoto.TipoLicencia());

        Autobus autobus = new Autobus
        {
            Marca = "Scania",
            Modelo = "Interurbano",
            AñoFabricacion = 2016,
            NumeroSerie = "WBA3B1C59EP679284",
            CapacidadPasajeros = 50
        };

        Console.WriteLine("\n");
        Console.WriteLine("\n" + autobus.Conducir());

        Console.WriteLine("\nMarca: " + autobus.Marca);
        Console.WriteLine("Modelo: " + autobus.Modelo);
        Console.WriteLine("Año de Fabricación: " + autobus.AñoFabricacion);
        Console.WriteLine("Numero de Serie: " + autobus.NumeroSerie);
        Console.WriteLine("Capacidad de Pasajeros: " + autobus.CapacidadPasajeros);


        Console.WriteLine("\nEl tipo de licencia requerido para este autobús es: " + autobus.TipoLicencia());

    }
}