using Sait.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sait
{
    public class SampleData
    {
        public static void Initialize(KitchenContext context)
        {
            if (!context.Kitchens.Any())
            {
                context.Kitchens.AddRange(
                    new Kitchen
                    {
                        Name = "Ника",
                        Price = 12000,
                        Style = "Лофт",
                        Available = "Доступно",
                        Description = "Красивая",
                        Image = "Ссылка"
                    },
                     new Kitchen
                     {
                         Name = "Венеция",
                         Price = 42000,
                         Style = "Лофт",
                         Available = "Доступно",
                         Description = "Красивая",
                         Image = "Ссылка"
                     }
                    );
                context.SaveChanges();
            }
        }
    }
}
