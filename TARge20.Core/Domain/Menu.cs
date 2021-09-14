using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string Meal { get; set; }
        public DateTime TimeOfMeal { get; set; }
        public int Portion { get; set; }
        public DateTime DayOfServing { get; set; }
        public string Comment { get; set; }
        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
