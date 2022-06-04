using System;
namespace Aporte_CalderonByron3A_Ej2
{
    class Factura
    {
        public void Pedir_valores()
        {
            int cantidad = 0;
            double total_new = 0, total = 0;
            do{
            Console.WriteLine("Ingresa la cantidad de productos vendidos o el valor de 0 para imprimir el total: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Ingresa el precio del producto vendido: ");
            double precio= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            //Calcular(cantidad, precio);
            if(cantidad!=0)
            {
                total = cantidad*precio;
                total_new = total + total_new;
            }
            }while(cantidad!=0);
            Imprimir(total_new);
        }
        public void Imprimir(double total_new)
        {
            Console.WriteLine("El valor total es: "+total_new);
        }
    }
}