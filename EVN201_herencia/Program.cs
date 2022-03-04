using System;

namespace _03_Herencia{
    
    class Program {
        static void Main(string[] args){
        Console.WriteLine("::: PROBANDO HERENCIA:::");
        //instacia trabajador que hereda Persona
        Trabajador objTrabajador1 = new Trabajador();
       
        //instanciamos la clase trabajador-persona ejecuto el 2do constructor
        Trabajador objTrabajador2 = new Trabajador(3600.0);
        Console.WriteLine("Salario: " + objTrabajador2.getSalario() );

        //instanciamos la clase trabajador-persona ejecuto el tercer constructor
        Trabajador objTrabajador3 = new Trabajador("Pablo",19,50000,5);
        Console.WriteLine("Salario: " + objTrabajador3.getSalario() );
        Console.WriteLine("Edad: " + objTrabajador3.getEdad() );
        Console.WriteLine("Nombre: " + objTrabajador3.getNombre() );
        
       
       
        /* Console.WriteLine("Ingresa nombre");
        objTrabajador1.setNombre(Console.ReadLine());
        Console.WriteLine("Ingresa edad");
        objTrabajador1.setEdad(int.Parse(Console.ReadLine()));
        //objTrabajador
        Console.WriteLine("Ingrese la antiguedad");
        objTrabajador1.setAntiguedad(int.Parse(Console.ReadLine()));
        Console.WriteLine("Ingrese su salario");
        objTrabajador1.setSalario(int.Parse(Console.ReadLine()));

        Console.WriteLine($"Edad: {objTrabajador1.getEdad()}"  );
        Console.WriteLine("Nombre: " + objTrabajador1.getNombre() );
        Console.WriteLine("Antiguedad" + objTrabajador1.getAntiguedad() );
        Console.WriteLine("Salario: " + objTrabajador1.getSalario() );

        Console.WriteLine("Despues del metodo cumple");
        objTrabajador1.cumple();
        Console.WriteLine("Edad: " + objTrabajador1.getEdad() );

        Console.WriteLine("Despues de salario");
        objTrabajador1.incremento();
        Console.WriteLine("Salario: " + objTrabajador1.getSalario() ); */
        
    }
    
    }
}