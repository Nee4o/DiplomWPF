
using System.Collections.Generic;


namespace DiplomWPF.Models
{
    public partial class Status
    {
        public Status()
        {
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
