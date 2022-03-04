using System;
namespace EVN201
{

    class act07_ejerc4{

        static void Mainuuihoi(string[] args){
            int counter = 0;
            int[,] matriz_1 = new int[3,3];
            int[,] matriz_2 = new int[3,3];
            int[,] suma = new int[3,3];

            Console.WriteLine("Ingresa los valores de la matris 1");
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine($"Ingresa el valor {i+1},{j+1}");
                    matriz_1[i, j ] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingresa los valores de la matris 2");
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine($"Ingresa el valor {i+1},{j+1}");
                    matriz_2[i, j ] = int.Parse(Console.ReadLine());
                    suma[i,j] = matriz_2[i, j] + matriz_1[i, j];
                }
            }
            Console.WriteLine("La matriz resultante es ");
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine($"valor {i+1},{j+1}");
                    Console.WriteLine(suma[i,j]);
                    
            }
            /// Console.WriteLine("\n");
        }
    }
}
}