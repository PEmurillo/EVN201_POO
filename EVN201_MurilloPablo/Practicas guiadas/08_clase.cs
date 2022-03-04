using System;
namespace EVN201
{

    class pablo{

        static void Main(string[] args){

            Console.WriteLine("INSTANCIANDO");
            Usuario objUsr1 = new Usuario();
            //llena objUsr1 con datos
            Console.WriteLine("Ingresa el username");
            objUsr1.setUsername(Console.ReadLine());

          
            }
                      
        }
    //Crea clase
    public class Usuario {
        //atributos 
        private string username;
        private string correo;
        private string contra;
        private int edad;
        private bool estatus;
        //contructor
        public Usuario(){
            this.username = "";
            this.correo = "";
            this.edad = 0;
            this.estatus = false;
            this.contra = "";
        }
        //propiedades   set/get
            //username
        public void setUsername(string username){
            this.username = username;
        }
        public string getUsername(){ return this.username;
        }
            //contra
        public void setContra(string contra) { this.contra = contra;
        }
        public string getContra() { return this.contra; }
            //correo
        public void setCorreo(string correo) { this.correo = correo;}
        public string getCorreo() { return this.correo; }
            //edad
        public void setNome(int edad) { this.edad = edad;}
            //estatus
        public void setEstatus(bool estatus) { this.estatus = estatus;}
        public bool getEstatus() { return this.estatus; }
        //métodos
        public void registrar(string a,string b,string c,int d){
            this.username = a;
            this.contra = b;
            this.correo = c;
            this.edad= d;
        }
    }

    }
