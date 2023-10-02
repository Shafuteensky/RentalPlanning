using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPlanning.Models
{
    public class Session
    {
        public List<Client> clients { get; set; }
        public List<Entry> entries { get; set; }

        public Session()
        {
            clients = new List<Client>
            {
                new Client() { Name = "Гаврилова Малика Максимовна", Id = 0 },
                new Client() { Name = "Воронин Павел Ильич", Id = 1 },
                new Client() { Name = "Латышева Ольга Богдановна", Id = 2 },
                new Client() { Name = "Хомяков Арсений Михайлович", Id = 3 },
                new Client() { Name = "Мельникова Ева Максимовна", Id = 4 },
                new Client() { Name = "Митрофанов Роман Васильевич", Id = 5 },
                new Client() { Name = "Петрова Мария Артёмовна", Id = 6 },
                new Client() { Name = "Ефимова Юлия Ивановна", Id = 7 },
                new Client() { Name = "Кузнецова Ева Львовна", Id = 8 },
                new Client() { Name = "Овсянникова Анна Тимофеевна", Id = 9 },
                new Client() { Name = "Демидова Алиса Егоровна", Id = 10 },
            };

            entries = new List<Entry>
            {
                new Entry() { },
                new Entry() { },
                new Entry() { },
                new Entry() { },
                new Entry() { },
                new Entry() { },
            };
        }

        public string? GetClientNameById(int id)
        {
            foreach (Client client in clients)
            {
                if (client.Id == id)
                    return client.Name;
            }
            return null;
        }
    }
}
