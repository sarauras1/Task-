using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{



    public class TipoTask
    {
       
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public DateTime DateScadenza { get; set; }
        public Livello Livello { get; set; }

     

        public TipoTask()
        {
        }

   
        public TipoTask(int id, string descrizione, DateTime dataScadenza, Livello livello)
        {
            Id = id;
            Descrizione = descrizione;
            DateScadenza = dataScadenza;
            Livello = livello;
        }

        internal string GetInfo()
        {
            return $" \t Id = {Id} Descrizione = {Descrizione} Data Scadenza = {DateScadenza} Livello = {Livello} \n";

        }

    }
    public enum Livello
    {
        Basso,
        Medio,
        Alto,
        Tutti
    }


}