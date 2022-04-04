using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sait.Models
{
    public class Feedback
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [Key] public string Phone { get; set; }
        public string Email { get; set; }
        public int Mark { get; set; }
        public string Text { get; set; } //стиль для фильтров Классика, Лофт, Модерн
        
    }
}