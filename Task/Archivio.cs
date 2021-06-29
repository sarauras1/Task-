using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
  
    public class Archivio
    {
        int id;
       public Dictionary<int, TipoTask> task = new Dictionary<int, TipoTask>();
        internal TipoTask AggiungiTask(string descrizione, DateTime dataScadenza, Livello livello)
        {
            TipoTask tasks = new TipoTask(++id, descrizione, dataScadenza, livello);
            task.Add(tasks.Id, tasks);

            return tasks;
        }

        internal string OttieniFiltro(Livello livello)
        {
            string s = "";

            foreach (TipoTask t in task.Values)
                if ( t.Livello == livello)
                    s += t.GetInfo() + '\n';

            return s;
        }
        internal string OttieniTask()
        {
            string s = "";
            foreach (TipoTask t in task.Values)
            {
                
                 s += t.GetInfo();
            }
            return s;
        }
    }
}