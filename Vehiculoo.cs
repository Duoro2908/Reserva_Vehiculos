using Reserva_Vehiculos;
using System.Runtime.CompilerServices;

namespace Reserva_Vehiculos
{
    public class Vehiculoo
    {
        public string Modelo { get; set; }

        public int Precio { get; set; }

        public Vehiculoo(string modelo, int precio)
        {
            Modelo = modelo;
            Precio = precio;
        }

        public class Descuento
        {
            public double Porcentaje_des {  get; set; }
            public Descuento(double Porcentaje)
            {
                Porcentaje_des = Porcentaje;
            }

            public static double Hacer_Desc(double precio_original, double descuento_porcentaje)
            {
                return precio_original - (precio_original * descuento_porcentaje / 100);
            }
        }
    }
}
public static class Vehiculoo_Ext
{ 
    public static void Mostrar_Info_Vehiculo(this Vehiculoo mivehiculo)
    {
        Console.WriteLine($"Modelo_del_vehiculo: {mivehiculo.Modelo}");
        Console.WriteLine($"Precio_del_vehiculo: {mivehiculo.Precio}");
    }
}
//El this es lo que lo hace un metodo de extension ya que Vehiculo es de mi primer clase
//clase estatica para calcular el valor de la reserva

public static class Calculo_Reserva_Vehiculo
{
    public static double Calcular_Costo_Total(Vehiculoo mivehiculo, int dias, double descuento)
    {
        double costo = mivehiculo.Precio * dias;
        costo = Vehiculoo.Descuento.Hacer_Desc( costo, descuento ); 
        return costo;
    }

}