using System;

namespace _03_Herencia{
    class Trabajador:Persona{
        //atributos 
        int antiguedad;
        double salario;
        //contructor

        
        public Trabajador(){
            antiguedad = 0;
            salario = 0;
        }
        //polimorfismo --sobreCarga --NO REQUIERE HERENCIA
        public Trabajador(double sueldoBase){
            this.salario=sueldoBase;
            this.antiguedad=0;
        }
        public Trabajador(string n,int e, double s, int a){
            this.setNombre(n);
            this.setEdad(e);
            this.salario= s;
            this.antiguedad=a;
        }
        //propiedades
        public void setAntiguedad(int antiguedad){
            this.antiguedad = antiguedad;
        }
        public int getAntiguedad(){
            return this.antiguedad;
        }
        public void setSalario(double salario){
            this.salario = salario;
        }
        public double getSalario(){
            return this.salario;
        }
        //metodos
        public void incremento(){
            this.salario= this.salario+500;

        }
        
    }
}