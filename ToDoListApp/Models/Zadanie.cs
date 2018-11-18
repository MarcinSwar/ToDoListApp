using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Models
{
    public class Zadanie
    {
        public int idZadanie { get; set; }

        public string Opis { get; set; }

        public Kategoria Kategoria { get; set; }

        public DateTime Deadline { get; set; }
    }
}
