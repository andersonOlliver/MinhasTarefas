using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Model.Util
{
    public class JobUtil : Job
    {

        public string Interval { get; set; }

        public JobUtil(string name, string description, DateTime from, DateTime to) 
            : base(name, description, from, to)
        {
            Initialize();
        }

        public JobUtil(int id, string name, string description, DateTime from, DateTime to) 
            : base(id, name, description, from, to)
        {
            Initialize();
        }

        private void Initialize()
        {
            Interval = From.Hour.ToString() + ":" + From.Minute.ToString()
                + " - " + To.Hour.ToString() + ":" + To.Minute.ToString();
        }
    }
}
