using System;
namespace _sondeo_{
    class Encuestado{
    //atributos
        private int totalEncuestas;
        private int mediaEncuestas;
        private int sumatoria;

    //contructor
        public Encuestado()
        { 
            this.totalEncuestas = 0;
            this.mediaEncuestas = 0;
            this.sumatoria = 0;
        }

    //propiedades
        public void addTotalEncuestas(){
            this.totalEncuestas = this.totalEncuestas + 1;
        }
        public int getTotalEncuestas(){
            return this.totalEncuestas;
        }

  
        public int getMediaEncuestas(){
            this.mediaEncuestas = this.sumatoria / this.totalEncuestas;
            return this.mediaEncuestas;
        }
        public void addSumatoria(int answer){
            this.sumatoria = this.sumatoria + answer;
        }
        public int getSumatoria(){
            return this.sumatoria;
        }
        
    //metodos
        public void RESET(){
            this.totalEncuestas = 0;
            this.mediaEncuestas = 0;
            this.sumatoria = 0;
        }

}
}