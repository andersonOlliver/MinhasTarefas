using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Model
{
    public class Job
    {
        public int JobId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public User User { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }


        public Job() { }

        public Job(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Job(string name, string description, DateTime from, DateTime to)
        {
            Name = name;
            Description = description;
            From = from;
            To = to;
        }

        public Job(int jobId, string name, string description, DateTime from, DateTime to)
        {
            JobId = jobId;
            Name = name;
            Description = description;
            From = from;
            To = to;
        }
    }
}
