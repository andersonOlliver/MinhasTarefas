using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Database
{
    public class WeekDB
    {

        public List<DayOfWeek> Days = new List<DayOfWeek>()
        {
            DayOfWeek.Monday,
            DayOfWeek.Sunday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday
        };

        public List<Job> Week = new List<Job>()
        {
            new Job()
            {
                JobId = 0,
                Name = "Acordar",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
            new Job()
            {
                JobId = 1,
                Name = "Segunda-feira",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
            new Job()
            {
                JobId = 2,
                Name = "Terça-feira",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
            new Job()
            {
                JobId = 3,
                Name = "Quarta-feira",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
            new Job()
            {
                JobId = 4,
                Name = "Quinta-feira",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
            new Job()
            {
                JobId = 5,
                Name = "Sexta-feira",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
            new Job()
            {
                JobId = 6,
                Name = "Sábado",
                To = DateTime.Now.AddHours(-1),
                From = DateTime.Now.AddHours(1)
            },
        };



    }
}
