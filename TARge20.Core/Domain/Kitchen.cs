using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Kitchen
    {
        public Guid Id { get; set; }
        public int HistoryOfJobs { get; set; }
        public string Comment { get; set; }

        public Guid? CookId { get; set; }
        [ForeignKey("CookId")]
        public Cook Cook { get; set; }

        public Guid? MenuId { get; set; }
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
    }
}
