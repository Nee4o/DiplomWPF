using System.Collections.Generic;

namespace DiplomWPF.Models
{
    public partial class Type
    {
        public Type()
        {
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
