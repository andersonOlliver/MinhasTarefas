using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class CalendarViewModel : BaseViewModel
    {

        public ObservableCollection<Meeting> Meetings { get; }
        List<string> eventNameCollection;
        List<Color> colorCollection;

        public CalendarViewModel()
        {
            Title = "Calendário";
            Meetings = new ObservableCollection<Meeting>();
            CreateEventNameCollection();
            CreateColorCollection();
            CreateAppointments();
        }

        private void CreateAppointments()
        {
            Random randomTime = new Random();
            List<Point> randomTimeCollection = GettingTimeRanges();
            DateTime date;
            DateTime DateFrom = DateTime.Now.AddDays(-10);
            DateTime DateTo = DateTime.Now.AddDays(10);
            DateTime dataRangeStart = DateTime.Now.AddDays(-3);
            DateTime dataRangeEnd = DateTime.Now.AddDays(3);

            for (date = DateFrom; date < DateTo; date = date.AddDays(1))
            {
                if ((DateTime.Compare(date, dataRangeStart) > 0) && (DateTime.Compare(date, dataRangeEnd) < 0))
                {
                    for (int AdditionalAppointmentIndex = 0; AdditionalAppointmentIndex < 3; AdditionalAppointmentIndex++)
                    {
                        Meeting meeting = new Meeting();
                        int hour = (randomTime.Next((int)randomTimeCollection[AdditionalAppointmentIndex].X, (int)randomTimeCollection[AdditionalAppointmentIndex].Y));
                        meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                        meeting.To = (meeting.From.AddHours(1));
                        meeting.EventName = eventNameCollection[randomTime.Next(9)];
                        meeting.color = colorCollection[randomTime.Next(9)];
                        Meetings.Add(meeting);
                    }
                }
                else
                {
                    Meeting meeting = new Meeting();
                    meeting.From = new DateTime(date.Year, date.Month, date.Day, randomTime.Next(9, 11), 0, 0);
                    meeting.To = (meeting.From.AddHours(1));
                    meeting.EventName = eventNameCollection[randomTime.Next(9)];
                    meeting.color = colorCollection[randomTime.Next(9)];
                    Meetings.Add(meeting);
                }
            }
        }

        private void CreateEventNameCollection()
        {
            eventNameCollection = new List<string>();
            eventNameCollection.Add("General Meeting");
            eventNameCollection.Add("Plan Execution");
            eventNameCollection.Add("Project Plan");
            eventNameCollection.Add("Consulting");
            eventNameCollection.Add("Performance Check");
            eventNameCollection.Add("Yoga Therapy");
            eventNameCollection.Add("Plan Execution");
            eventNameCollection.Add("Project Plan");
            eventNameCollection.Add("Consulting");
            eventNameCollection.Add("Performance Check");
        }

        private void CreateColorCollection()
        {
            colorCollection = new List<Color>();
            colorCollection.Add(Color.FromHex("#117EB4"));
            colorCollection.Add(Color.FromHex("#B4112E"));
            colorCollection.Add(Color.FromHex("#C44343"));
            colorCollection.Add(Color.FromHex("#11B45E"));
            colorCollection.Add(Color.FromHex("#43BEC4"));
            colorCollection.Add(Color.FromHex("#B4112E"));
            colorCollection.Add(Color.FromHex("#C44343"));
            colorCollection.Add(Color.FromHex("#117EB4"));
            colorCollection.Add(Color.FromHex("#C4435A"));
            colorCollection.Add(Color.FromHex("#DF5348"));
            colorCollection.Add(Color.FromHex("#43c484"));
        }

        private List<Point> GettingTimeRanges()
        {
            List<Point> randomTimeCollection = new List<Point>();
            randomTimeCollection.Add(new Point(9, 11));
            randomTimeCollection.Add(new Point(12, 14));
            randomTimeCollection.Add(new Point(15, 17));
            return randomTimeCollection;
        }
    }
}
