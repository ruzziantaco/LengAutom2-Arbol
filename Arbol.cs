using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;

namespace Arbol
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************************Menu de nicio**********************************");
            Console.WriteLine("                    *Escribe 'y' para si & 'n' para no*");
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("    >>Te gustan las matematicas?");
           
            string x;
            x = Console.ReadLine();
            try
            {
                if (x == "y")
                {
                    Console.WriteLine("    >>Eres sociable?");

                    x = Console.ReadLine();
                    if (x == "y")
                    {
                        Console.WriteLine("    >>Quieres una Ingenieria?");
                        x = Console.ReadLine();
                        if (x == "y")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Ing. Industrial");
                            Console.ReadKey();


                        }
                        if (x == "n")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Licenciatura en Administracion");
                            Console.ReadKey();
                        }

                    }
                    if (x == "n")
                    {
                        Console.WriteLine("    >>Quieres una ingenieria?");
                        x = Console.ReadLine();
                        if (x == "y")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Ing. en Sistemas");
                            Console.ReadKey();


                        }
                        if (x == "n")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lic. en Informatica");
                            Console.ReadKey();
                        }
        
                    }
              
                }
                if (x=="n")
                {
                    Console.WriteLine("    >>Eres sociable?");
                    x = Console.ReadLine();
                    if (x == "y")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Te interesa lo audiovisual?");
                        x = Console.ReadLine();
                        if (x == "y")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lic en comunicacion");
                            Console.ReadKey();


                        }
                        if (x == "n")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Licenciatura en Psicologia");
                            Console.ReadKey();
                        }
            

                    }
                    Console.ReadKey();
                    if (x == "n")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("    >>Te interesa lo audiovisual?");
                        x = Console.ReadLine();
                        if (x == "y")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lic. en Artes");
                            Console.ReadKey();


                        }
                        if (x == "n")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lic. en Criminologia");
                            Console.ReadKey();
                        }
            

                    }
            

                }
       
            }
            catch (Exception)
            {
                Console.WriteLine("####No eligio una opcion correcta####");
                Console.ReadKey();

            }

            Console.ReadKey();


        }
    }
}
