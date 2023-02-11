using System;

namespace DiplomWPF.Models
{
    public partial class Request
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int WorkerId { get; set; }

        public virtual Status StatusNavigationId { get; set; }
        public virtual Type TypeNavigationId { get; set; }
        public virtual Worker WorkerNavigationId { get; set; }
    }
}
