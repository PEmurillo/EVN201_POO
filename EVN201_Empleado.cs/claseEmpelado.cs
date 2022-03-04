using System;

namespace _02_empelado{

    class Empleado{
        //atributos 
        private string nombre;
        private string apellido;
        private bool genero;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private double salario;
        //contructor
        public Empleado(){
            this.nombre = "";
            this.apellido = "";
            this.genero = false;
            this.salario = 0.0;
        }
        //propiedades   set/get
            //nombre
        public void setNombre(string nombre){
            this.nombre = nombre;
        }
        public string getNombre(){ return this.nombre; }
            //apellido
        public void setApellido(string apellido) { this.apellido = apellido; }
        public string getApellido() { return this.apellido; }
           //genero
       public void setGenero(bool genero) { this.genero = genero;}
        public bool getGenero() { return this.genero; }
            //salario
        public void setSalario(double salario) { this.salario = salario; }
        public double getSalario() { return this.salario; }
            //Fecha Nacimiento
        public void setFechaNacimiento(int a,int m,int d){
            this.fechaNacimiento = new DateTime(a,m,d);}
            //Fecha de ingreso
        public void setFechaIngreso(int a,int m,int d){
            this.fechaNacimiento = new DateTime(a,m,d);
        }
        
        

        //métodos
        public void infoEmpleados(){}
        public void modificarSalario(){}
        public void calcularEdad(){}
        public void
    }
}

