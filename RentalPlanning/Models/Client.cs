using System;
using System.Collections.Generic;
using Windows.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI;

namespace RentalPlanning.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Colour { get; set; }

        public string Contact_number { get; set; }
        public int Rating { get; set; }
        public string Notes { get; set; }

        public Client()
        {
            var rnd = new Random();
            var notes = new List<string> { "Замечаний нет", "-", "Замечания есть" };
            var states = new List<bool> { true, false };

            Id = rnd.Next(0, 100);
            Name = "Ивань Иванов";
            Colour = Windows.UI.Color.FromArgb(255, 255, 1, 1);
            Contact_number = "+9965"+Convert.ToString(rnd.Next(00000000, 99999999));
            Rating = rnd.Next(1, 5);
            Notes = notes.ElementAt(rnd.Next(0, 2));
        }
    }
}
