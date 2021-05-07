using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class TipoTask
    {

        //Costruttore
        public TipoTask(string bassa, string media, string alta)
        {
            TaskBassa = bassa;
            TaskAlta = alta;
            TaskMedia = media;
        }

        public string TaskBassa { get; }
        public string TaskAlta { get; }
        public string TaskMedia { get; }

        public string OttieniDati
        {
            get
            {
                return ($"{TaskBassa}-{TaskMedia}-{TaskAlta}");
            }
        }

        public bool InserisciTaskBassa { get; internal set; }
        public bool InserisciTaskMedia { get; internal set; }
        public bool InserisciTaskAlta { get; internal set; }
    }



}
