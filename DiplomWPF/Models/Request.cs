using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DiplomWPF.Models
{
    public partial class Request
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Description { get; set; }
        public int IdType { get; set; }
        public int IdStatus { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int IdWorker { get; set; }

        public virtual Status IdStatusNavigation { get; set; }
        public virtual Type IdTypeNavigation { get; set; }
        public virtual Worker IdWorkerNavigation { get; set; }
    }
}
