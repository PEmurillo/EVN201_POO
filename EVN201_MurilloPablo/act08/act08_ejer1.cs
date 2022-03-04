using System;
namespace EVN201
{

    class act08{

        static void Main7865(string[] args){
          
            while(true){

                int option = seleccion();
                if(option == 2){
                    Console.WriteLine("¿Cuantos productos deseas ingresar?");
                    int nProduct = int.Parse(Console.ReadLine());
                    string[] products = new string[nProduct];
                    int[] prices = new int[nProduct];



                } 

                if(option == 1){
                    Console.WriteLine("Bienvenido");

                }


            }
            
        }

        static int seleccion(){
            Console.WriteLine("Bienvenido, selecciona tu perfil");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 -Administrador");
            return int.Parse(Console.ReadLine());
        }

        public static void showProduct (string[] names, int[] prices){
            for(int i = 0; i < names.Length; i++){
                Console.WriteLine($"{i+1} - {names[i]} ${prices[i]}");
            }
        }
    }
}