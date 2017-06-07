using EnumSample.Helpers;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.Model
{

    public enum DayWeek
    {
        [EnumValueData(Name = "Domingo", KeyValue = "Domingo")]
        Dom,
        [EnumValueData(Name = "Segunda", KeyValue = "Segunda")]
        Seg,
        [EnumValueData(Name = "Terça", KeyValue = "Terça")]
        Ter,
        [EnumValueData(Name = "Quarta", KeyValue = "Quarta")]
        Qua,
        [EnumValueData(Name = "Quinta", KeyValue = "Quinta")]
        Qui,
        [EnumValueData(Name = "Sexta", KeyValue = "Sexta")]
        Sex,
        [EnumValueData(Name = "Sábado", KeyValue = "Sábado")]
        Sab
    }

    [Table("job")]
    public class Job
    {

        [PrimaryKey, AutoIncrement]
        public int JobId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //public User User { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public DayWeek Day { get; set; }

        //public Color Color { get; set; }


        public Job() {
            From = DateTime.Now;
            To = DateTime.Now.AddHours(1);
        }

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
