using System;
namespace EVN201

{
    //Estrucura para definir las especificaciones del viaje
    struct travel {
                public int days;
                public int hotel;
                public int[] tour;
                public int cost;
            };

    class act05_ejerc2{

        //Muestra las opciones de hoteles
        static void hotels(){
            Console.WriteLine("¿Donde te gustaria hospedarte?");
            Console.WriteLine("1 - Hilton $60/day");
            Console.WriteLine("2 - Morian $45/day");
            Console.WriteLine("3 - Holiday $38/day");
        }
        //Muestra los tours disponibles
        static void tours(){
            Console.WriteLine("¿Qué tours te gustaria tomar?");
            Console.WriteLine("1 - Estatua de la Libertad $35");
            Console.WriteLine("2 - Empire State $30");
            Console.WriteLine("3 - Bus por Manhattan $50");
        }

        static void Main_act5_2(string[] args){
            //Creamos un nuevo viaje
            travel user = new travel();
            //El costo toma valor 0 como default
            user.cost = 0;
            //Array que contiene el costo de los viajes
            int[] pricesTours = new int[]{ 35, 30, 50};

            //Array que contiene el costo de los hoteles
            int[] pricesHotel = new int[]{ 60, 45, 38};

            user.tour = new int[]{0,0,0};

            int cost = 0;
            

            //Inicia el programa
            while (true) {
            
            //Preguntamos al usuario el número de dias
            Console.WriteLine("¿Cuantos dias te gustaria viajar");
            //Asignamos el número recibo en el viaje creado
            user.days = int.Parse(Console.ReadLine());
            
            //Mostramos la lista de hoteles
            hotels();
            
            //Definimos el hotel seleccionado en el viaje
            user.hotel = int.Parse(Console.ReadLine());
            user.cost =+ pricesHotel[user.hotel-1]*user.days;

            Console.WriteLine(user.cost);
            //Mostramos la lista de tours
            tours();
            
            for (int i = 0; i < 3; i++) {
                //Preguntamos la cantidad de veces que desea tomar el tour
                Console.WriteLine("¿Cuantas veces te gustaria tomar el tour "+(i+1)+"? ");
                //Almacenamos su seleccion del viaje i
                user.tour[i] = int.Parse(Console.ReadLine());

                //Sumamos al costo las veces que se toma el tour    
                cost = cost+(user.tour[i]*pricesTours[i]);
                
            }
            user.cost = cost+user.cost;
            Console.WriteLine("Costo de hotel: "+pricesHotel[user.hotel-1]*user.days);
            Console.WriteLine(user.tour[0]+" Tours por la estatua: "+user.tour[0]*pricesTours[0]);
            Console.WriteLine(user.tour[1]+"Tours por el empire states: "+user.tour[1]*pricesTours[1]);
            Console.WriteLine(user.tour[2]+"Tours por Manhattan: "+user.tour[2]*pricesTours[2]);
            Console.WriteLine("Costo total: "+user.cost);
            
            Console.WriteLine("Desea volver a hacer el presupuesto? 1/si 2/no");
            int aux = int.Parse(Console.ReadLine());

            if (aux == 1){
                continue;
            } if (aux == 2){
                break;
            }


            }
             
        }
    }
}