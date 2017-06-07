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

        public static List<DayWeek> Days = new List<DayWeek>()
        {
            DayWeek.Dom,
            DayWeek.Seg,
            DayWeek.Ter,
            DayWeek.Qua,
            DayWeek.Qua,
            DayWeek.Sex,
            DayWeek.Sab
        };
        
    }
}
