using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Child
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string GroupHistory { get; set; }
        public string ParentName { get; set; }
        public string ParentAddress { get; set; }
        public int ParentPhoneNumber { get; set; }
        public string ParentEmail { get; set; }
        public string Comment { get; set; }
        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
