using System;
namespace EVN201
{

    class act07_ejerc2{

        static void Main7865(string[] args){
            int counter = 0;
            int[] valores= {721,9,423,56,23,34,966,78,79,3664,12,5516,15};
            foreach(int i in valores){
                if(i>99 && i<1000){counter = counter + 1;}
            }
            Console.WriteLine($"Cantidad de numeros positivos y de tres cifras {counter}");            
        }
    }
}