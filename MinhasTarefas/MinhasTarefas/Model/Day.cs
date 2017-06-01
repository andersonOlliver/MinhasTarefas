using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Model
{
    public class Day
    {
        public int DayId { get; set; }

        public string Name { get; set; }

        public DateTime DayOnCalendar { get; set; }

        public User User { get; set; }


    }
}
