using System;
namespace EVN201
{
    class act05_ejerc1{

       
        
        static void menu(){
            Console.WriteLine("¿Qué le gustaria ordenar?");
                Console.WriteLine("1 - Arañitas de desebrada en salsa verde $64");
                Console.WriteLine("2 -Albonidas con chipotle $70");
                Console.WriteLine("3 - Burritos $20");
                Console.WriteLine("4 - Tortitas de papa $50");
                Console.WriteLine("Porfavor seleccione su pedido");

        }

        static void cuenta(int food_1, int food_2, int food_3, int food_4){
                Console.WriteLine(food_1 + " Arañitas $"+ food_1 * 64);
                Console.WriteLine(food_2 + " Albondigas $"+ food_2 * 70);
                Console.WriteLine(food_3 + " Burritos $"+ food_3 * 20);
                Console.WriteLine(food_4 + " Arañitas $"+ food_4 * 50);
                Console.WriteLine("Total $"+((food_1 * 64)+(food_2 * 70)+(food_3 * 20)+(food_4 * 50)));
        }

        static void Main_act5_1(string[] args){
            int[] orders = new int[]{ 0, 0, 0,0 };
            int aux;
            Console.WriteLine("Bienvenido a la cocina de Paz");

            while(true){
                
                menu();
                int selec = int.Parse(Console.ReadLine());
        
                Console.WriteLine("Cuantas ordenes desea");
                int n = int.Parse(Console.ReadLine());    
                

                switch(selec){
                    case 1:
                        orders[0]=orders[0]+n;
                        break;
                    case 2:
                        orders[1]=orders[1]+n;
                        break;
                    case 3:
                        orders[2]=orders[2]+n;
                        break;
                    case 4:
                        orders[3]=orders[3]+n;
                        break;
                }
                
                Console.WriteLine("¿Desea añadir algo a su pedido? 1=si 2=no" );
                aux = int.Parse(Console.ReadLine());
            
                
                if(aux==1){
                    continue;
                }if(aux == 2){
                    cuenta(orders[0],orders[1],orders[2],orders[3]);
                    Console.WriteLine("¿Todo esta en orden? 1-Correcto 2-Deseo modificar mi orden");
                    aux = int.Parse(Console.ReadLine());
                    if(aux == 1){
                        Console.WriteLine("Disfrute de su pedido, vuelva pronto");
                        break;
                    }if(aux == 2){
                            continue;
                        }
                }

                

            }
            
            

        }

        

    }

}