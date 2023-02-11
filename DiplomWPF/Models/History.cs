using System;

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
