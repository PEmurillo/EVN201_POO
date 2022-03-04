using System;
namespace EVN201
{

    class act03_ejerc2{

        static void Main234(string[] args){
            Console.WriteLine("¿Cuanto dinero quiere invertir?");
            string parse = Console.ReadLine();
            int inversion = int.Parse(parse);

            Console.WriteLine("¿Cuantos meses quiere invertir?");
            parse = Console.ReadLine();
            int meses = int.Parse(parse);
            double ganancias = ((inversion * 0.02)*meses);

            Console.WriteLine("Tus ganancias son: "+ganancias);

            
            
           
            
        }
    }
}