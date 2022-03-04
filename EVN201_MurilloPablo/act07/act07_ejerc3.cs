using System;
namespace EVN201
{

    class act07_ejerc_1{

        static void Main123687(string[] args){
            Console.WriteLine("Ingresa el valor de n filas");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de m  columnas");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,m];
            int max = 0, i_max = 0, j_max = 0;
            int pass;
            for(int i = 0; i < n; i++ ){

                for(int j = 0; j < m; j++){
                    Console.WriteLine($"Ingresa el valor de {i+1} x {j+1}");
                    pass = int.Parse(Console.ReadLine());
                    matrix[i,j] = pass;

                    if(pass > max){
                        max = pass;
                        i_max = i + 1;
                        j_max = j + 1;
                    }
                }
            }
            
           Console.WriteLine($"El valor maximo es : {max} en la posición {i_max} {j_max}");
            
        }
    }
}