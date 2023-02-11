using System;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DiplomWPF.Models
{
    public partial class History
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int WorkerId { get; set; }

        public virtual Worker WorkerNavigationId { get; set; }
    }
}
