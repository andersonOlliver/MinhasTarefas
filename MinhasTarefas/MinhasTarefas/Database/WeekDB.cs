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
        public List<Day> Week = new List<Day>()
        {
            new Day()
            {
                DayId = 0,
                Name = "Domingo",
                DayOnCalendar = DateTime.Now
            },
            new Day()
            {
                DayId = 1,
                Name = "Segunda-feira",
                DayOnCalendar = DateTime.Now
            },
            new Day()
            {
                DayId = 2,
                Name = "Terça-feira",
                DayOnCalendar = DateTime.Now
            },
            new Day()
            {
                DayId = 3,
                Name = "Quarta-feira",
                DayOnCalendar = DateTime.Now
            },
            new Day()
            {
                DayId = 4,
                Name = "Quinta-feira",
                DayOnCalendar = DateTime.Now
            },
            new Day()
            {
                DayId = 5,
                Name = "Sexta-feira",
                DayOnCalendar = DateTime.Now
            },
            new Day()
            {
                DayId = 6,
                Name = "Sábado",
                DayOnCalendar = DateTime.Now
            },
        };
    }
}
