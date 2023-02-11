

namespace DiplomWPF.Models
{
    public partial class JobName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual SystemAdministrator SystemAdministrator { get; set; }
    }
}
