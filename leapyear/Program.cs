using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            
            bool salir = false;
            string otravez
            while (salir != true)
            {
                int anio, ultimas2_cifras;
                Console.Write("Ingrese el año ");
                anio = Convert.ToInt32(Console.ReadLine());
                ultimas2_cifras = anio % 20;


                if (ultimas2_cifras % 4 == 0)
                {
                    Console.WriteLine(anio + " Es Bisiesto");
                }


                else
                {
                    Console.WriteLine(anio + " No es Bisiesto");
                }
               
                Console.WriteLine("Desea ingresar otro año s/n");
                otravez = Console.ReadLine();
                if (otravez == "n")
                {
                    salir = true;
                }
            }
            
            
            
            
 


        
        
        }
    }
}
