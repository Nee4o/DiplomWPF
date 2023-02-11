using System;


namespace DiplomWPF.Models
{
    public partial class Cost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Amount { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
