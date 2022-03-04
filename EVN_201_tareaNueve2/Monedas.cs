using System;
namespace _monedas_{
    class Alcancia{
    //atributos 
    private int monedasUno;
    private int monedasDos;
    private int monedasCinco;
    private int monedasDiez;
    private int monedasVeinte;

    //constructor
    public Alcancia(){
        this.monedasUno = 0;
        this.monedasDos = 0;
        this.monedasCinco = 0;
        this.monedasDiez = 0;
        this.monedasVeinte = 0;
    }
    //propiedades
        
        //Monedas de uno
        public void setMonedasUno(int cantidad){
            this.monedasUno = cantidad;
        }

        public int getMonedasUno(){
            return this.monedasUno;
        }

        //Monedas de dos
        public void setMonedasDos(int cantidad){
            this.monedasDos = cantidad;
        }

        public int getMonedasDos(){
            return this.monedasDos;
        }

        //Monedas de cinco
        public void setMonedasCinco(int cantidad){
            this.monedasCinco = cantidad;
        }

        public int getMonedasCinco(){
            return this.monedasCinco;
        }

        //Monedas de diez
        public void setMonedasDiez(int cantidad){
            this.monedasDiez = cantidad;
        }
        public int getMonedasDiez(){
            return this.monedasDiez;
        }

        //Monedas de Veinte
        public void setMonedasVeinte(int cantidad){
            this.monedasVeinte = cantidad;
        }
        public int getMonedasVeinte(){
            return this.monedasVeinte;
        }

    
    //metodos
    public void reset(){
        this.monedasUno = 0;
        this.monedasDos = 0;
        this.monedasCinco = 0;
        this.monedasDiez = 0;
        this.monedasVeinte = 0;
    }
    public void addMonedas(){
        Console.WriteLine("¿Qué tipo de moneda quieres añadir?");
        Console.WriteLine("1 -  $1 uno ");
        Console.WriteLine("2 - $2 dos ");
        Console.WriteLine("3 - $5 cinco ");
        Console.WriteLine("4 - $10 Diez ");
        Console.WriteLine("5 - $20 Veinte ");
        int select = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Cuantas monedas quieres añadir?");
        int  cantidad = int.Parse(Console.ReadLine());
        
        switch(select) {
        case 1:
            this.setMonedasUno(cantidad + getMonedasUno());
            break;
        case 2:
            this.setMonedasDos(cantidad + getMonedasDos());
            break;
        case 3:
            this.setMonedasCinco(cantidad +  getMonedasCinco());
            break; 
        case 4:
            this.setMonedasDiez(cantidad + getMonedasDiez());
            break;
        case 5:
            this.setMonedasVeinte(cantidad + getMonedasVeinte());
            break;
    }
        
    }
    public int getTotalMonedas(){
        int total = getMonedasUno() + getMonedasDos() * 2 + getMonedasCinco() * 5 + getMonedasDiez() * 10 + getMonedasVeinte() * 20;
        return total;
    }

    public void getMonedas(){
        Console.WriteLine($"Monedas de $1 : {this.getMonedasUno()}");
        Console.WriteLine($"Monedas de $2 : {this.getMonedasDos()}");
        Console.WriteLine($"Monedas de $5 : {this.getMonedasCinco()}");
        Console.WriteLine($"Monedas de $10 : {this.getMonedasDiez()}");
        Console.WriteLine($"Monedas de $20 : {this.getMonedasVeinte()}");
    }
    
    }

    

    }
    
   