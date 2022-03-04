using System;

namespace _02_empelado
{
    class Fechas{

        static void Main(string[] args){
        DateTime hoy = DateTime.Now;
        DateTime myBorn;

        Console.WriteLine("Añade tu año en el formato aaaa");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Añade tu mes en el formato mm");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Añade tu mes en el formato dd");
        int day=hoy.Day;
        
        DateTime miNac = new DateTime(year,05,09);
        int edad= hoy.Year-miNac.Year;
        Console.WriteLine(edad);

        DateTime nacAhora=miNac.AddYears(edad);
        if(nacAhora.CompareTo(hoy)>0){

        }

        }
        

    }
}