using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DiplomWPF.Models
{
    public partial class Worker
    {
        public Worker()
        {
            History = new HashSet<History>();
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Cabinet { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<History> History { get; set; }
        public virtual ICollection<Request> Request { get; set; }
    }
}
