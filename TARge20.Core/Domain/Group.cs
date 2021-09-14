using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public string NameOfGroup { get; set; }
        public string GroupType { get; set; }
        public string Comment { get; set; }

        public Guid? EducatorId { get; set; }
        [ForeignKey("EducatorId")]
        public Educator Educator { get; set; }

        public Guid? SeniorEducatorId { get; set; }
        [ForeignKey("SeniorEducatorId")]
        public Senior_Educator Senior_Educator { get; set; }

        public Guid? MethodologistId { get; set; }
        [ForeignKey("MethodologistId")]
        public Methodologist Methodologist { get; set; }

        public Guid? ChildId { get; set; }
        [ForeignKey("ChildId")]
        public Child Child { get; set; }

        public Guid? CookId { get; set; }
        [ForeignKey("CookId")]
        public Cook Cook { get; set; }
    }
}
