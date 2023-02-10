

namespace DiplomWPF.Models
{
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
