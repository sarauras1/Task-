using System;
using System.Collections.Generic;
namespace Task
{


    class Program
    {



     private static Archivio manager = new Archivio();
      
        static void Main(string[] args)
        {
           
            Console.WriteLine("Gestione tasks");
            Menu();

        }

        private static void Menu()
        {
            do
            {
                TipoTask tipo = new TipoTask();
                Console.WriteLine();
                Console.WriteLine("1. Crea task");
                Console.WriteLine("2. Visualizza tasks");
                Console.WriteLine("3. Filtra tasks");
           
                Console.WriteLine("5. Elimina task");
                Console.WriteLine("0. Esci");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        CreaTask(tipo);
                        break;
                    case '2':
                        Visualizza();
                        break;
                    case '3':
                        Filtra(tipo.Livello);
                        break;
              
                    case '5':
                        EliminaTask();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            } while (true);
        }
    

        private static void EliminaTask()
        {
           
            Console.WriteLine("Elimina Tast tramite id");
            int id = Convert.ToInt32(Console.ReadLine());
             manager.task.Remove(id);// elimina solo l id ma non il row connesso
        }

      
        private static void Filtra(Livello livello)
        {
          
            Console.Write("--Seleziona livello---");
            Console.Write("---1. Basso - 2. Medio - 3. Alto--");
            string scelta = Console.ReadLine();

            do
            {
               
                switch (scelta)
                {
                     case "1":
                        livello = Livello.Basso;
                        break;
               
                    case "2":
                        livello = Livello.Medio;
                        break;
                    case "3":
                        livello = Livello.Alto;
                        break;
                }
            } while (scelta != "1" && scelta != "2" && scelta != "3");

            Console.WriteLine(manager.OttieniFiltro(livello));
            
          
            
        }

        private static void Visualizza()
        { 
         Console.WriteLine(manager.OttieniTask());                              
        }

        private static void CreaTask(TipoTask tipo)
        {
         

          
          
                Console.WriteLine();
                Console.Write("Descrizione del task: ");
                tipo.Descrizione = Console.ReadLine();
                Console.WriteLine("Data Scadenza");                                   
                tipo.DateScadenza = Convert.ToDateTime(Console.ReadLine());
                try
                {
                    if (DateTime.Today > tipo.DateScadenza)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }catch(Exception e)

                {
                    Console.WriteLine($"Data invalida {e.Message}");
                }
                    
               
                Console.WriteLine("Scelta Livello");
                Console.WriteLine("1 per Bassa");
                Console.WriteLine("2 per Media");
                Console.WriteLine("3 per Alta");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        tipo.Livello = Livello.Basso;
                        break;
                    case "2":
                        tipo.Livello = Livello.Medio;
                        break;
                    case "3":
                        tipo.Livello = Livello.Alto;
                        break;
                }

            manager.AggiungiTask(tipo.Descrizione, tipo.DateScadenza, tipo.Livello);
             Console.WriteLine($"Task: {tipo.Id++} {tipo.Descrizione} {tipo.DateScadenza} {tipo.Livello} ---  Creata");

             VuoiTornare(tipo);
                    

        }
      
        private static void VuoiTornare(TipoTask tipo)
        {
           
            Console.WriteLine("Vuoi tornare al menu principale?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. Vuoi Creare un altra task");
            Console.WriteLine("3. No");
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    Menu();
                    break;
                case "2":
                    CreaTask(tipo);
                    break;
                case "3":
                    Console.WriteLine("GoodBye");
                    return;
              
            }
        }
    }
}
