using System;

namespace Reserva_Vehiculos
{
    class Program
    {
          public  static void Main(string[] args)
          {

            string modelo = "Bugatti Cayse";
            int precio = 20000;
            int dias = 2;
            double descuento = 10.0; 

            Console.WriteLine($"Modelo predeterminado: {modelo}");
            Console.WriteLine($"Precio predeterminado: {precio}");
            Console.WriteLine($"Días de reserva predeterminados: {dias}");
            Console.WriteLine($"Descuento predeterminado: {descuento}%");
            Console.WriteLine("El costo total de la reserva con un descuento del 10% es:36,000.");
            Console.WriteLine("***********************************");


            Console.WriteLine("Bienvenidos a nuestro Concesionario de vehiculos!!!!!!!");

            Console.WriteLine("Lo anterior era un ejemplo de como usar nuestro sistema");
        

            Console.WriteLine("Ingrese el modelo del vehículo que desee por favor :");
            modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del vehículo:");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias que quiere la reserva:");
            dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de descuento de el dia de hoy:");
            descuento = double.Parse(Console.ReadLine());

            Vehiculoo miVehiculo = new Vehiculoo(modelo, precio);

            miVehiculo.Mostrar_Info_Vehiculo();

            double costoTotal = Calculo_Reserva_Vehiculo.Calcular_Costo_Total(miVehiculo, dias, descuento);

            Console.WriteLine($"El costo total de la reserva con un descuento del {descuento}% es: {costoTotal}.");

            Console.WriteLine("___Gracias por Preferirnos estaremos esperandolo nuevamente___");
        }
    }
 }