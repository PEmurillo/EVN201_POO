using System;
namespace EVN201{  

    class act07_ejerc1{
        static void Main_aaa(string[] args){
            Console.WriteLine("¿Cuantos numeros desea introducir");
            int positive = 0;
            int negative = 0;
            int answer = int.Parse(Console.ReadLine());
            int[] numeros = new int[answer];
            int aux;

            for(int i = 0; i < answer; i++){
                Console.WriteLine($"Introduce el numero {i+1}: ");
                aux = int.Parse(Console.ReadLine());
                numeros[i] = aux;
                if(aux>0 && aux!=0){
                    positive = positive + 1;} else{
                        negative = negative + 1;}
                    }
                Console.WriteLine($"Cantidad de numeros positivos: {positive} \nCantidad de numeros negativos: {negative}");
            for(int j=0;j<numeros.Length;j++){
                Console.WriteLine(numeros[j]);
            }
            }
            

        }

    } 
