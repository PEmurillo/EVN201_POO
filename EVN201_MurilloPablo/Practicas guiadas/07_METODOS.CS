using System;
namespace EVN201
{

    class metodoBB{

        static void Main74879841(string[] args){
            
            int select = 0;
            do{
                select=menu();

                
                if(select==0){
                    break;
                }
            }  while(select<0 | select>2);
        }

        static int menu(){
            Console.WriteLine("¿Qué deseas hacer?");
            Console.WriteLine("1) CALIFICAR 2)REGALAR 0)SALIR");
            return int.Parse(Console.ReadLine());;
        }
    }
}