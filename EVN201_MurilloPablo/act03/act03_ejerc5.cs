using System;
namespace EVN201
{

    class act03_ejerc5{

        static void Main23(string[] args){
            
            
            Console.WriteLine("Ingrese el número de kilometros");
            string parse = Console.ReadLine();
            int km = int.Parse(parse);
            Console.WriteLine("Número de millas: "+(km * 0.62137119));
           
            
        }
    }
}