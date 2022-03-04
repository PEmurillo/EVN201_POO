using System;

namespace _sondeo_{
    class Program{
        static void Main(string[] args){
           Encuestado menores18Soltero = new Encuestado();
           Encuestado menores18Casados = new Encuestado();
           Encuestado mayores18Soltero = new Encuestado();
           Encuestado mayores18Casado = new Encuestado(); 
           Encuestado mayores55soltero = new Encuestado();
           Encuestado mayores55Casado = new Encuestado();

            int menu;
            int loop = 100;
            int promedioGlobal;
            int numeroEncuestasGlobal = 0;
            int sumatoriaGlobal = 0;
            int response;
            int rangoEdad;
            int estadoCivil;

           do
           {
            estadoCivil = 0;
            rangoEdad = 0;

            Console.WriteLine("::::: S E L E C C I O N A    U N A    O P C I O N :::::");
            Console.WriteLine("1 - Añadir respuesta");
            Console.WriteLine("2 - Visualizar promedio total de encuestas");
            Console.WriteLine("3 - Visualizar el numero total de encustados");
            Console.WriteLine("4 - Consultar datos por rango de edad y estado civil");
            Console.WriteLine("0 - Salir del programa");
             menu = int.Parse(Console.ReadLine());
               switch (menu)
               {
                   case 0:
                   loop = 0;
                   break;

                   case 1:

                   
                    Console.WriteLine("¿a que rango de edad perteneces?");
                    Console.WriteLine("1 - menor de 18");
                    Console.WriteLine("2 - Entre 18 y 55");
                    Console.WriteLine("3 - Mayor de 55");
                    rangoEdad = int.Parse(Console.ReadLine());
                    
        
                    Console.WriteLine("¿Cual es tu estado civil?");
                    Console.WriteLine("1 - soltero/a");
                    Console.WriteLine("2 - Casado/a");
                    estadoCivil = int.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Del 1 al 10 especifica cuanto te gusta el agua de jamaica");
                     response =  int.Parse(Console.ReadLine());

                     numeroEncuestasGlobal = numeroEncuestasGlobal + 1;
                     sumatoriaGlobal = sumatoriaGlobal + response;

                    switch (rangoEdad)
                    {
                    case 1:
                        if (estadoCivil == 1){
                            menores18Soltero.addTotalEncuestas();
                            menores18Soltero.addSumatoria(response);
                        } if (estadoCivil == 2){
                            menores18Casados.addTotalEncuestas();
                            menores18Casados.addSumatoria(response);
                        }
                    break;

                    case 2:
                        if(estadoCivil == 1){
                            mayores18Soltero.addTotalEncuestas();
                            mayores18Soltero.addSumatoria(response);
                        } if (estadoCivil == 2){
                            mayores18Casado.addTotalEncuestas();
                            mayores18Casado.addSumatoria(response);
                        }
                    break;
                    case 3:
                        if(estadoCivil == 1){
                            mayores55soltero.addTotalEncuestas();
                            mayores55soltero.addSumatoria(response);
                        } if(estadoCivil == 2){
                            mayores55Casado.addTotalEncuestas();
                            mayores55Casado.addSumatoria(response);
                        }
                        break;
            
                    }
                    break;

                    case 2:
                        promedioGlobal = sumatoriaGlobal / numeroEncuestasGlobal;
                        Console.WriteLine($"El promedio total de encuestas es {promedioGlobal}");
                    break;
                    case 3:
                        Console.WriteLine($"El numero total de encuestas es {numeroEncuestasGlobal}");
                    break;
                    case 4:
                    Console.WriteLine("¿Que rango de edad desea consultar?");
                    Console.WriteLine("1 - menor de 18");
                    Console.WriteLine("2 - Entre 18 y 55");
                    Console.WriteLine("3 - Mayor de 55");
                    rangoEdad = int.Parse(Console.ReadLine());
                    
        
                    Console.WriteLine("¿Qué estado civil desdea consultar?");
                    Console.WriteLine("1 - soltero/a");
                    Console.WriteLine("2 - Casado/a");
                    estadoCivil = int.Parse(Console.ReadLine());
                   
                    

                    switch (rangoEdad)
                    {
                    case 1:
                        if (estadoCivil == 1){
                            Console.WriteLine($"El numero de encuestados es {menores18Soltero.getTotalEncuestas()}");
                            Console.WriteLine($"El promedio es {menores18Soltero.getMediaEncuestas()}") ;
                            
                        } if (estadoCivil == 2){
                            Console.WriteLine($"El numero de encuestados es {menores18Casados.getTotalEncuestas()}");
                            Console.WriteLine($"El promedio es {menores18Casados.getMediaEncuestas()}") ;
                            
                        }
                    break;

                    case 2:
                        if(estadoCivil == 1){
                            Console.WriteLine($"El numero de encuestados es {mayores18Soltero.getTotalEncuestas()}");
                            Console.WriteLine($"El promedio es {mayores18Soltero.getMediaEncuestas()}") ;
                           
                        } if (estadoCivil == 2){
                            Console.WriteLine($"El numero de encuestados es {mayores18Casado.getTotalEncuestas()}");
                            Console.WriteLine($"El promedio es {mayores18Casado.getMediaEncuestas()}") ;
                            
                        }
                    break;
                    case 3:
                        if(estadoCivil == 1){
                            Console.WriteLine($"El numero de encuestados es {mayores55soltero.getTotalEncuestas()}");
                            Console.WriteLine($"El promedio es {mayores55soltero.getMediaEncuestas()}") ;
                            
                        } if(estadoCivil == 2){
                            Console.WriteLine($"El numero de encuestados es {mayores55Casado.getTotalEncuestas()}");
                            Console.WriteLine($"El promedio es {mayores55Casado.getMediaEncuestas()}") ;
                            
                            
                        }
                        break;
            
                    }

                    break;
               }


                   

                   
               
           } while (loop!=0);
        
    
    
}
}
}