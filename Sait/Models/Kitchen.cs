using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sait.Models
{
    public class Kitchen
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Style { get; set; } //стиль для фильтров Классика, Лофт, Модерн
        public string Available { get; set; } //наличие 
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
