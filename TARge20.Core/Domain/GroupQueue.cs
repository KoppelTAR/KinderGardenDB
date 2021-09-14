using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class GroupQueue
    {
        public Guid Id { get; set; }
        public string OpenGroups { get; set; }
        public int Slots { get; set; }
        public string Comment { get; set; }

        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        public Guid? ChildId { get; set; }
        [ForeignKey("ChildId")]
        public Child Child { get; set; }
    }
}
