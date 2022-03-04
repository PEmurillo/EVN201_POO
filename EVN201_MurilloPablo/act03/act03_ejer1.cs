using System;
namespace EVN201
{

    class act03_ejerc1{

        static void Main11(string[] args){
            
            
            Console.WriteLine("Ingrese el número de semanas");
            string parse = Console.ReadLine();
            int numSemanas = int.Parse(parse);
            Console.WriteLine("Número de días: "+(numSemanas * 7));
           
            
        }
    }
}