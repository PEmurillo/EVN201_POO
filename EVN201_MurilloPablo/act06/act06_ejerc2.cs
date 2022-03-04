using System;
namespace EVN201
{

    class act06_ejerc2{

        static void Main_XD(string[] args){
            string[] conso = new string[]{"A","E","I","O","U"};
            string[] consoAcent = new string[]{"Á","É","Í","Ó","Ú"};
            String withoutSpace = "_";
            String code;
            
            Console.WriteLine("Ingrese el titulo del libro: ");
            string bookName = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese la editorial del libro: ");
            string editorial = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingresa la edicion del libro");
            string edicion = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingresa el idioma del libro");
            string idiom = Console.ReadLine().ToUpper();


            withoutSpace =  bookName.Replace(" ", String.Empty);
            for (int i = withoutSpace.Length; withoutSpace.Length < 10; i++){
                withoutSpace += "0";
            }

            code = ((editorial.Substring(0,1))+(editorial.Substring((editorial.Length)-2,2))+(idiom.Substring(0,2))+"_"+withoutSpace.Substring(0,10));
            for (int i = 0 ; i < conso.Length; i++){
                code = code.Replace(consoAcent[i],conso[i]);
            }
            
            Console.WriteLine(code);
           
            

           
            
        }
    }
}