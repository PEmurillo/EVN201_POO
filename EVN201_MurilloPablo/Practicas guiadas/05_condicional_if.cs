using System;
namespace EVN201
{

    class Program5{

        static void Main123(string[] args){
            
            
            Console.WriteLine("Ingrese la calificacion");
            string parse = Console.ReadLine();
            int calif = int.Parse(parse);

            if (calif >= 8){
                Console.WriteLine("Califiación aprobatoria");
            } else {
                Console.WriteLine("Calififación reprobatoria");
            }

            
           
            
        }
    }
}