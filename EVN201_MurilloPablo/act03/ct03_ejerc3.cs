using System;
namespace EVN201
{

    class act03_ejerc3{

        static void Main3556(string[] args){
            
            
            Console.WriteLine("¿Cual es el precio del producto?");
            string parse = Console.ReadLine();
            int cost = int.Parse(parse);
            Console.WriteLine("Costo total : "+((cost * 0.16)+cost));
           
            
        }
    }
}