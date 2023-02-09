using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DiplomWPF.Models
{
    public partial class Report
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public decimal Costs { get; set; }
    }
}
