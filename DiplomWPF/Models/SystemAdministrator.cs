namespace DiplomWPF.Models
{
    public partial class SystemAdministrator
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int JobNameId { get; set; }

        public virtual JobName JobNameNavigationId { get; set; }
    }
}
