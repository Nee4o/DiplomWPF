﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomWPF.Models;

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
}