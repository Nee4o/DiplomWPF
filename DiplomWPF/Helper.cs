namespace DiplomWPF.Models
{
    /// <summary>
    /// Class containing Worker data
    /// </summary>
    public partial class Worker
    {
        public string FIO
        {
            get
            {
                return $"{Surname} {Name} {Patronymic}";
            }
        }
    }
    /// <summary>
    /// Class containing Report data
    /// </summary>
    public partial class Report
    {
        public string Price
        {
            get
            {
                return $"{Costs} ₽";
            }
        }
    }
    /// <summary>
    /// Class containing Cost data
    /// </summary>
    public partial class Cost
    {
        public string price
        {
            get
            {
                return $"{Price} ₽";
            }
        }
    }
}
