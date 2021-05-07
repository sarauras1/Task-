using System;
using System.Collections.Generic;
using System.IO;
namespace Task
{

    enum Formato
    {
        Normale,
        CSV
    }
    class Program
    {

        private static Archivio Tasks = new Archivio();
        private static string fileName = "archivio.csv";
        static void Main(string[] args)
        {
           
            Console.WriteLine("Benvenuto");
            do
            {    
              
                Console.WriteLine("Scegli opzione task:");
                Console.WriteLine("1. Bassa");
                Console.WriteLine("2. Media");
                Console.WriteLine("3. Alta");
                Console.WriteLine("0. Esci");
                Console.WriteLine("Scegli F per visualizzare i file:");
                Console.WriteLine("1. Salva per salvare le tue tasks");

                //lista aggiornata
                List<TipoTask> listaAgg = Tasks.OttieniTasksAgg();

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        if (listaAgg.Count > 0)
                      
                            foreach (TipoTask task in listaAgg)
                                Console.WriteLine(task.InserisciTaskBassa);
                     
                
                break;
                    case '2':
                        if (listaAgg.Count > 0)
                      
                       foreach (TipoTask task in listaAgg)
                       Console.WriteLine(task.InserisciTaskMedia);
                       
                break;
                    case '3':
                        if (listaAgg.Count > 0)

                            foreach (TipoTask task in listaAgg)
                                Console.WriteLine(task.InserisciTaskAlta);
                        break;
                    case 'T':
                        Carica();
                        break;
                    case 'F':
                        Salva();
                        break;
                    case '0':
                        return;
                }

            } while (true);
          

        }

       

        private static void Carica()
        {
            using (StreamReader sw = new StreamReader(fileName))
            {
                string contenuto = sw.ReadToEnd();
                Tasks.Carica(contenuto);
            }
        }

        private static void Salva()
        {
            using (StreamWriter sw = new StreamWriter(fileName))
                sw.Write(Tasks.OttieniTasksAgg(Formato.CSV));
        }

    }
}

