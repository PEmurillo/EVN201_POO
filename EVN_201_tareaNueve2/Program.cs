using System;

namespace _monedas_{
    class Program {
        static void Main(string[] args) {
            Alcancia monedero = new Alcancia();
            int loop=100;
            int menu;
            do
            {
                Console.WriteLine("::::: S E L E C C I O N A    U N A    O P C I O N :::::");
                Console.WriteLine("1 - Consultar saldo total");
                Console.WriteLine("2 - Consultar cantidad de monedas por denominacion");
                Console.WriteLine("3 - Añadir monedas");
                Console.WriteLine("4 - Romper la alcancia");
                Console.WriteLine("0 - Salir del programa");
                menu = int.Parse(Console.ReadLine());
                switch (menu){
                    case 0: 
                        loop = 0;
                        break;
                    case 1:
                        Console.WriteLine($"Dinero total ${monedero.getTotalMonedas()}");
                    break;

                    case 2:
                        monedero.getMonedas();
                    break;

                    case 3:
                        monedero.addMonedas();
                        break;
                    case 4:
                        Console.WriteLine($"Se rompio la alanacia con {monedero.getTotalMonedas()}");
                        Console.WriteLine("Generamos una nueva alcancia ;)");
                        monedero.reset();
                        break;
                }
                
            } while (loop!=0);

            Console.WriteLine("::::::: V U E L V A   P R O N T O ::::::");
        }
    }
}