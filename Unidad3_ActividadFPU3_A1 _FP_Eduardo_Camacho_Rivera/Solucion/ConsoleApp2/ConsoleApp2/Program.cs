using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

            //Se establecen las variables que se van a estar usando 
        {
           int Primer_candidato= 0, segundo_candidato= 0, tercer_candidato = 0, cuarto_candidato = 0, quinto_candidato = 0;
            double un_nombre, resultado_suma, resultado_division;

           //Personalizamos la consola para que se vea mas coqueta ;)

            Console.BackgroundColor= ConsoleColor.Cyan;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();
            Console.BufferHeight = 30;
            Console.BufferWidth = 120;

            //Proseguimos con lo mero mero caguamero e iniciamos con un "for" para que nuestro proyecto sea repetitvo
            //tambien agregamos a nuestros señores candidatos y una opcion para poder votar por estos mismos repetitivamente 

            for (; ; )
            {
             
                Console.WriteLine("                                                      INSTRUCCIONES                                          \n");
                Console.WriteLine("  para votar por su candidato solo presione en su teclado el numero que aparece junto a este mismo y despues enter\n ");
                Console.WriteLine("La consola esta formulada para poder votar de manera progresiva por 1 o mas candidatos hasta que teclee el numero 0\n");
                Console.WriteLine("      Cuando termine de realizar la votacion por favor presione la tecla 0 y luego enter para realziar el conteo\n");
                Console.WriteLine("                                          CANDIDATOS POR LOS QUE PUEDE VOTAR \n");
                Console.WriteLine("Aldo #1\n");
                Console.WriteLine("Jared #2\n");
                Console.WriteLine("Eduardo #3\n");
                Console.WriteLine("Tony #4\n");
                Console.WriteLine("Mary #5\n");
                un_nombre = Convert.ToInt16(Console.ReadLine());


                //Los siguientes if nos ayudan a que sea le agregue un valor de "1" a cada candidato que sea votado 
                
                if (un_nombre == 1)
                {
                    Primer_candidato = Primer_candidato + 1;
                    Console.Clear();
                }
                if (un_nombre == 2)
                {
                    segundo_candidato = segundo_candidato + 1;
                    Console.Clear();
                }
                if (un_nombre == 3)
                {
                    tercer_candidato = tercer_candidato + 1;
                    Console.Clear();
                }
                if (un_nombre == 4)
                {
                    cuarto_candidato = cuarto_candidato + 1;
                    Console.Clear();
                }
                if (un_nombre == 5)
                {
                    quinto_candidato = quinto_candidato + 1;
                    Console.Clear();
                }
                Console.Clear();
               
                //el siguiente if es el que inicia la division del 100% de los votos entre etotal de los votos por los votos del candidato en solitario
                //esto solo se va a ejecutar cuando el votante presione la letra 0 
               
                if (un_nombre == 0)
                {
                    Console.WriteLine ("                             Resultados de las votaciones\n                                          ");



                    resultado_suma = (Primer_candidato + segundo_candidato + tercer_candidato +  cuarto_candidato + quinto_candidato);

                    resultado_division = (100 / resultado_suma) * Primer_candidato;
                    Console.WriteLine("El candidato Aldo obtuvo un porcentaje de {0}  % Con  la cantidad de {1} votos \n", resultado_division,Primer_candidato);
                    resultado_division = (100 / resultado_suma) * segundo_candidato;
                    Console.WriteLine("El candidato Jared obtuvo un porcentaje de {0} % Con la cantidad de {1} votos\n", resultado_division,segundo_candidato);
                    resultado_division = (100 / resultado_suma) * tercer_candidato;
                    Console.WriteLine("El candidato Eduardo obtuvo un  porcentaje de {0} % Con la cantidad de {1} votos\n", resultado_division,tercer_candidato);
                    resultado_division = (100 / resultado_suma) * cuarto_candidato;
                    Console.WriteLine("El candidato Tony Obtuvo un porcentaje de {0} % Con la  cantidad de {1} votos\n", resultado_division,cuarto_candidato);
                    resultado_division = (100 / resultado_suma) * quinto_candidato;
                    Console.WriteLine("El candidato Mary obtuvo un  porcentaje de {0} % Con la cantidad de {1} votos\n", resultado_division,quinto_candidato);
                   
                    
                    //una animacion guapa de cierre de consola ;)
                    Console.WriteLine("En 5 segundos la pagina se autodestruira.");
                    Thread.Sleep(1000);
                    Console.WriteLine("En 4 segundos la pagina se autodestruira..");
                    Thread.Sleep(1000);
                    Console.WriteLine("En 3 segundos la pagina se autodestruira...");
                    Thread.Sleep(1000);
                    Console.WriteLine("En 2 segundos la pagina se autodestruira....");
                    Thread.Sleep(1000);
                    Console.WriteLine("En 1 segundos la pagina se autodestruira.....");
                    Thread.Sleep(1000);
                    Console.WriteLine("Caboom!");
                    Thread.Sleep(1000);
                    return;

                    
                }
                



            }
               

             




            //El maravilloso Readkey que permite que nuestra consola se vea
            Console.ReadKey();
        }
    }
}
