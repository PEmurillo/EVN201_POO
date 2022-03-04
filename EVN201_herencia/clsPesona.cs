using System;
namespace _03_Herencia{
    class Persona{
    //atributos 
    private string nombre;
    private int edad;

    //constructor
    public Persona(){
        this.nombre = "";
        this.edad = 0;
    }
    //propiedades
    public void setNombre(string nombre){
        this.nombre = nombre;
    }

    public string getNombre(){

        return this.nombre;
    }

    public void setEdad(int e){
        this.edad = e;
    }

    public int getEdad(){
        return this.edad;
    }
    //metodos
    public int cumple(){
        int edad = this.edad + 1;
        this.edad = edad;
        return this.edad;
    
    }
    
    }

    }
    
   
