using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Database
{
    public class JobDB
    {

        public List<JobPerDay> JobsWeek = new List<JobPerDay>()
        {
            new JobPerDay()
            {
                Day = "Domingo",
                Jobs = new List<JobUtil>(){

                    new JobUtil(1, "Tarefa 01", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                    new JobUtil(2, "Tarefa 02", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                    new JobUtil(3, "Tarefa 03", "Descrição", DateTime.Now.AddHours(-1), DateTime.Now.AddHours(1))
                }
            },
            new JobPerDay()
            {
                Day = "Segunda",
                Jobs = new List<JobUtil>(){
                    new JobUtil(4, "Tarefa 04", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                    new JobUtil(5, "Tarefa 05", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                    new JobUtil(6, "Tarefa 06", "Descrição", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(1))

                }
            }
        };

    }
}
