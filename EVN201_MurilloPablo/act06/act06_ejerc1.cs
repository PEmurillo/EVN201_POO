using System;
namespace EVN201
{

    class act06_ejerc1{

        static void Main_act6_1(string[] args){
            string curp;
            string[] conso = new string[]{"A","E","I","O","U"};
            string[] consoAcent = new string[]{"Á","É","Í","Ó","Ú"};

            Console.WriteLine("Ingrese su primer nombre");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese su primer apellido");
            string firstLastname = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese su segundo apellido");
            string secondLastname = Console.ReadLine().ToUpper();

            Console.Write("introduce tu fecha de nacimiento (e.g. 10/22/1987): ");
            DateTime inputdate = DateTime.Parse(Console.ReadLine()); 

            Console.WriteLine("Ingrese su sexo M o H");
            string sex = Console.ReadLine().ToUpper();

            curp = firstLastname.Substring(0,1);

            for (int i = 1; i < firstLastname.Length; i++){

                for (int j = 0; j<conso.Length ;j++){
                    if(firstLastname[i].ToString().Equals(conso[j])){
                        curp += firstLastname[i].ToString(); 
                        break;
                        }  
                    } 
                    if(curp.Length ==2){
                            break;
                    }   
                }

            curp+=secondLastname[0];
            curp+=name[0];
            curp = curp.ToUpper();
            curp += inputdate.ToString("yyMMdd");
            curp += sex.ToUpper();

            for (int i = 0 ; i < conso.Length; i++){
                curp = curp.Replace(consoAcent[i],conso[i]);
            }

            Console.WriteLine(curp);
            
            } 
        }
    }
