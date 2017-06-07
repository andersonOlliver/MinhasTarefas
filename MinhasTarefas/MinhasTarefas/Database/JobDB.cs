using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MinhasTarefas.Database
{
    public class JobDB
    {

        private SQLiteConnection _database;

        public JobDB()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Job>();
        }

        public List<Job> GetJobs()
        {
            return _database.Table<Job>().ToList();
        }

        public List<Job> GetJobsDay(DayWeek day)
        {
            return _database.Table<Job>().Where(j => j.Day == day).ToList();
        }

        public List<DayWeek> GetDays()
        {
            var list = _database.Query<Job>("select j.Day from Job as j group by j.Day");
            List<DayWeek> dataList = new List<DayWeek>();
            foreach(var aux in list)
            {
                dataList.Add(aux.Day);
            }

            return dataList.Distinct().ToList();
        }

        public int Save(Job job)
        {
            return _database.Insert(job);
        }

        public int Update(Job job)
        {
            return _database.Update(job);
        }

        public int Remove(Job job)
        {
            return _database.Delete(job);
        }

        public List<JobPerDay> JobsWeek { get; set; } 

        private void Initialize()
        {
            this.JobsWeek = new List<JobPerDay>()
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
                    Day = "Segunda-feira",
                    Jobs = new List<JobUtil>(){
                        new JobUtil(4, "Tarefa 04", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                        new JobUtil(5, "Tarefa 05", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                        new JobUtil(6, "Tarefa 06", "Descrição", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(1))

                    }
                },
                new JobPerDay()
                {
                    Day = "Terça-feira",
                    Jobs = new List<JobUtil>(){

                        new JobUtil(1, "Tarefa 01", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                        new JobUtil(2, "Tarefa 02", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                        new JobUtil(3, "Tarefa 03", "Descrição", DateTime.Now.AddHours(-1), DateTime.Now.AddHours(1))
                    }
                },
                new JobPerDay()
                {
                    Day = "Quarta-feira",
                    Jobs = new List<JobUtil>(){
                        new JobUtil(4, "Tarefa 04", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                        new JobUtil(5, "Tarefa 05", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                        new JobUtil(6, "Tarefa 06", "Descrição", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(1))

                    }
                },
                new JobPerDay()
                {
                    Day = "Quinta-feira",
                    Jobs = new List<JobUtil>(){
                        new JobUtil(4, "Tarefa 04", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                        new JobUtil(5, "Tarefa 05", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                        new JobUtil(6, "Tarefa 06", "Descrição", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(1))

                    }
                },
                new JobPerDay()
                {
                    Day = "Sexta-feira",
                    Jobs = new List<JobUtil>(){

                        new JobUtil(1, "Tarefa 01", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                        new JobUtil(2, "Tarefa 02", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                        new JobUtil(3, "Tarefa 03", "Descrição", DateTime.Now.AddHours(-1), DateTime.Now.AddHours(1))
                    }
                },
                new JobPerDay()
                {
                    Day = "Sábado",
                    Jobs = new List<JobUtil>(){
                        new JobUtil(4, "Tarefa 04", "Descrição", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4)),

                        new JobUtil(5, "Tarefa 05", "Descrição", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3)),

                        new JobUtil(6, "Tarefa 06", "Descrição", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(1))

                    }
                }
            };
        }
        
    }
}
