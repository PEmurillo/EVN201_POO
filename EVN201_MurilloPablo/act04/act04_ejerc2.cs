using System;
namespace EVN201
{
    class act04_ejerc2{

        static void Main45(string[] args){
            int pay;
            Console.WriteLine("Ingrese el número de horas trabajadas");
            int hrs = int.Parse(Console.ReadLine());
            
            if(hrs < 30){
                pay = 120;
            } else {
                pay = 200;
            }

            Console.WriteLine("Horas trabajadas: "+hrs);
            Console.WriteLine("Sueldo por hora: "+pay);
            Console.WriteLine("Sueldo total : "+hrs*pay);

        }

    }

}