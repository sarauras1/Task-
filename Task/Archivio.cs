using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Archivio
    {   

        //inizializza lista tasks
        List<TipoTask> Tasks = new List<TipoTask>();

        public TaskScheduler InserisciTaskBassa()
        {
            Console.WriteLine("Inserisci nuova task Bassa");
            string newT = Console.ReadLine();
            //aggiungo alla lista dei libri
            Tasks.Add(newT);
            return newT;
        }
        public TaskScheduler InserisciTaskMedia()
        {
            Console.WriteLine("Inserisci nuova task Media");
            string newTask = Console.ReadLine();
            //aggiungo alla lista dei libri
            Tasks.Add(newT);
            return newT;
        }

        internal List<TipoTask> OttieniTasksAgg(Formato CSV)
        {
            return Tasks;
        }

        internal List<TipoTask> OttieniTasksAgg()
        {
            throw new NotImplementedException();
        }

        public TaskScheduler InserisciTaskAlta()
        {
            Console.WriteLine("Inserisci nuova task Alta");
            string newTask = Console.ReadLine();
            //aggiungo alla lista dei libri
            Tasks.Add(newT);
            return newT;
        }

        internal void Carica(string contenuto)
        {
            Tasks.Clear();

            foreach(string r in righe)
        }
    }


   
}
