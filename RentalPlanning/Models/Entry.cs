using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RentalPlanning.Models
{
    public class Entry
    {
        Random rnd = new Random();

        public int Id { get; set; }
        public int Client_id { get; set; }

        public DateTime Arrival_date { get; set; }
        public DateTime Departure_date { get; set; }

        public int Fee_per_day { get; set; }
        public int Duration_days { get; set; }
        public int Prepay_val { get; set; }
        public float Dollar_rate { get; set; }

        public Entry()
        {
            Id = 1;
            Client_id = rnd.Next(0, 10);
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            Arrival_date = new[] { date1, date2 }.Min();
            Departure_date = new[] { date1, date2 }.Max();
            Fee_per_day = rnd.Next(90, 150);
            Duration_days = rnd.Next(1, 14);
            Prepay_val = rnd.Next(0, (Fee_per_day * Duration_days));
            Dollar_rate = (float)Math.Round((rnd.Next(78, 110) + rnd.NextDouble()), 2);
        }

        public string GetDatesRangeStr()
        {
            string date_range = Arrival_date.ToString("dd.mm.yyyy") + " - " + Departure_date.ToString("dd.mm.yyyy");
            return date_range;
        }

        DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2023, 6, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }

}
