using System;
namespace EVN201
{

    class act03_ejerc4{

        static void Main67(string[] args){
            
            
            Console.WriteLine("¿Cual es su año de nacimiento");
            string parse = Console.ReadLine();
            int anoNac = int.Parse(parse);
            parse = DateTime.Now.ToString("yyyy");
            int anoAct = int.Parse(parse);


            Console.WriteLine("Edad: "+(anoAct-anoNac));
           
            
        }
    }
}