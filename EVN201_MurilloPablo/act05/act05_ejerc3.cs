using System;
namespace EVN201
{

    class act05_ejerc3{

        static void Main_act5_3(string[] args){
            int suma = 0;
            int promedio;
            
            Console.WriteLine("Te gustaria saber tu promedio? 1/si 2/no");
            int aux = int.Parse(Console.ReadLine());

            if (aux == 1){
                Console.WriteLine("¿Cuantas materias tienes?");
                int numMaterias = int.Parse(Console.ReadLine());
                for (int i = 0; i < numMaterias; i++) {
                    Console.WriteLine("Ingresa tu calificación de la materia: "+ i+1);
                    suma += int.Parse(Console.ReadLine());
                }
                promedio = suma/numMaterias;
                Console.WriteLine("Tu promedio es: "+promedio);
            } if (aux == 2){
                Console.WriteLine("Continua estudiando :D");
            }
           
            
        }
    }
}